using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using proyecto_too.Models;

namespace proyecto_too.Controllers
{
    public class RegistroController : Controller
    {
       
        public ViewResult Registro()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Registro(Usuario2 user)
        {

            if (user.Nombre == null || user.Pasword == null || user.Pasword2 == null || user.Email == null)
            {
                return View(user);
            }
            else { 
                using (var db = new Models.bdtooContext())
                {
                    //se crea una instacia de AES
                    Aes EAes = Aes.Create();
                    Usuario user2 = new Usuario();
                    //escriptando la clave
                    user2.Nombre = user.Nombre;
                    user2.Email = user.Email;
                    user2.KeY = EAes.Key;
                    user2.Vi = EAes.IV;
                    user2.Pasword = EncryptStringToBytes_Aes(user.Pasword, EAes.Key, EAes.IV);
                    // Registra los datos en la base 
                    db.Usuarios.Add(user2);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("index", "Home");
        }
       

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
    }
}
