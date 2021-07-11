using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using projetos.DataBase.Connection.DatabaseConfig;
using projetos.DataBase.Repository.Interfaces;
using projetos.Models;

namespace projetos.DataBase.Repository.Implementation
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DatabaseConfig _connection;
        public ProdutoRepository(DatabaseConfig connection) 
        {
            _connection = connection;
        }
        
        public async void Create(Produto produto)
        {
            try 
            {
                using (var conn = new SQLiteConnection(_connection.Connection))
                {
                    const string query = @"INSERT INTO Produtos (Nome, Ativo, Descricao, Valor, Quantidade)
                        VALUES (@Nome, @Ativo, @Descricao, @Valor, @Quantidade)";
                    await conn.ExecuteAsync(query, new { produto.Nome, produto.Ativo, produto.Descricao, 
                    produto.Valor, produto.Quantidade}, commandType: CommandType.Text);
                }
            } catch (Exception e)
            {
                new Exception(e.Message);
            }
        }

        public async Task<string> Delete(long id)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connection.Connection))
                {
                    conn.Open();
                    const string query = @"DELETE FROM Produtos WHERE Id = @Id";
                    var sucess = await conn.QueryAsync(query, new {id}, commandType:CommandType.Text);
                    conn.Close();
                    return "Produto Deletado";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            try
            {
                IEnumerable<Produto> produto;
                using (var conn  =  new SQLiteConnection(_connection.Connection))
                {
                    const string query = @"Select * from Produtos";
                    produto = await conn.QueryAsync<Produto>(query, commandType: CommandType.Text);
                }
                return produto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
        }

        public async Task<Produto> GetId(long id)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connection.Connection))
                {
                    conn.Open();
                    const string query = @"SELECT * FROM Produtos WHERE Id = @id";
                    Produto produto = await conn.QueryAsync(query, new {id}, commandType: CommandType.Text);
                    conn.Close();
                    return produto;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<string> Update(long id)
        {
            try
            {
                using (var conn = new SQLiteConnection(_connection.Connection))
                {
                    conn.Open();
                    const string query = @"UPDATE Produto SET Nome = @Nome,
                        Ativo = @Ativo, Descricao = @Descricao, Valor = @Valor, 
                        Quantidade = @Quantidade WHERE (Id = @Id)";
                    await conn.QueryAsync(query, new {id}, commandType: CommandType.Text);
                    return "Produto Alterado";
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}