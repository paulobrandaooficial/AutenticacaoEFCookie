using AutenticacaoEFCookie.Models;

namespace AutenticacaoEFCookie.Dados
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContexto contexto){
            contexto.Database.EnsureCreated();

            var usuario = new Usuario(){
                NomeUsuario  = "Fernando",
                Email = "fernando.guerra@corujasdev.com.br",
                Senha = "123456" 
            };
            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                NomePermissao = "Financeiro",               
            };
            contexto.Permissoes.Add(permissao);

            var usuariopermissao = new UsuarioPermissao(){
                IdPermissao = permissao.IdPermissao,
                IdUsuario   = usuario.IdUsuario
            };
            contexto.UsuarioPermissoes.Add(usuariopermissao);

            contexto.SaveChanges(); 

        }
    }
}