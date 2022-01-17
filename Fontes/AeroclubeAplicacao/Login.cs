using System;
using Microsoft.EntityFrameworkCore;
using Aeroclube;
using System.Linq;
using Newtonsoft.Json;
namespace AeroclubeAplicacao
{
    public class Login
    {

        public string getLogin(string pNmUsuario, string pDsSenha)
        {
            var dbAeroClube = new AeroClubeContext();
            var usuario = new Aeroclube.Usuario();
            usuario = dbAeroClube.Usuario.Single(ObjUsuario => ObjUsuario.NmUsuario == pNmUsuario.Trim() && ObjUsuario.DsSenha == pDsSenha);
            return JsonConvert.SerializeObject(usuario);
            

        }
    }
}
