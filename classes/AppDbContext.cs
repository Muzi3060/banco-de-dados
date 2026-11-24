using Microsoft.EntityFrameworkCore;

namespace ExerciciosBancoDeDados.classes;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; } // gaveta

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=ExerciciosBancoDeDados.db");
        // configurando o provedor SQlite com o arquivo de banco de dados ExerciciosBancoDeDados.db
    }
}