using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDSQueueClass
{
    public class Usuario
    {
        // Propriedades da classe:
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        // Métodos construtores da classe:
        public Usuario() { }
        public Usuario(int id, string nome, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        // Métodos da classe
        /// <summary>
        /// Recebe o id do usuario.
        /// </summary>
        /// <returns>Retorna informações de acordo com o id inserido do Usuario(Classe)</returns>
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetBoolean(4)
                    );
            }

            return usuario;
        }
        /// <summary>
        /// Exibe uma lista de usuários.
        /// </summary>
        /// <returns>Retorna um objeto lista(List<>) do tipo Usuario(Classe)</returns>
        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from usuarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetBoolean(4)
                    )
                );
            }
            return lista;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into usuarios (nome, email, senha, ativo)" +
                $"values('{Nome}', '{Email}', md5('{Senha}'), default";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }   
}
