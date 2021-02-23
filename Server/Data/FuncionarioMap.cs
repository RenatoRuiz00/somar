using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Somar.Shared.Models;

namespace Somar.Server.Data
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionarios");

            //builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("autonum");

            builder.Property(c => c.Nome)
                .HasColumnName("nome");

            builder.Property(c => c.DtAdmissao)
                .HasColumnName("dataadmissao");

            builder.Property(c => c.DtDemissao)
                .HasColumnName("datademissao");

            builder.Property(c => c.Endereco)
                .HasColumnName("endereco");

            builder.Property(c => c.Bairro)
                .HasColumnName("bairro");

            builder.Property(c => c.Cidade)
                .HasColumnName("cidade");

            builder.Property(c => c.Cep)
                .HasColumnName("cep");

            builder.Property(c => c.Telefone)
                .HasColumnName("fone");

            builder.Property(c => c.DtNascimento)
                .HasColumnName("datanascimento");

            builder.Property(c => c.Email)
                .HasColumnName("email");

            builder.Property(c => c.Usuario)
                .HasColumnName("usuario");

            builder.Property(c => c.Senha)
                .HasColumnName("senha");

            builder.Property(c => c.FuncaoId)
                .HasColumnName("id_funcao");

            builder.Property(c => c.Antecipar)
                .HasColumnName("antecipar");

            builder.Property(c => c.TurnoId)
                .HasColumnName("id_turno");
        }
    }
}
