using Microsoft.AspNetCore.Mvc;
using Sistema_Web.Models;
using System.Security.Cryptography;


namespace Sistema_Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult LoginIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginIn(LoginInViewModel Lvm)
        {
            var Usuarios = _context.Usuarios.ToList();
            if (Usuarios.Count == 0)
            {
                Usuario U = new Usuario();
                U.Name = "Administrador";
                U.Email = "admin@admin.cl";
                U.Username = "admin";
                U.Rol = "SuperAdministrador";
                CreatePasswordHash("admin", out byte[] PasswordHash, out byte[] PasswordSalt);
                U.PasswordHash = PasswordHash;
                U.PasswordSalt = PasswordSalt;
                _context.Add(U);
                _context.SaveChanges();
            }
            else
            {
                //Proceso de Verificacion
                var Us = _context.Usuarios
                    .Where(u => u.Username.Equals(Lvm.Username)).FirstOrDefault();

                if(Us != null)
                {
                    if(VerificarPass(Lvm.Password, Us.PasswordHash, Us.PasswordSalt))
                    {
                        //LoginIn
                    }
                    else
                    {
                        ModelState.AddModelError("", "Contraseña Incorrecta!");
                        return View(Lvm);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Usuario NO Existe!");
                    return View(Lvm);
                }


            }



            return View();
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //administrador 123456
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerificarPass(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var pass = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return pass.SequenceEqual(passwordHash);
            }
        }


    }
}
