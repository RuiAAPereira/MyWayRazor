﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWayRazor.Data;

namespace MyWayRazor.Data.Migrations
{
    [DbContext(typeof(MywayDbContext))]
    partial class MywayDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWayRazor.Models.Assistencia", b =>
                {
                    b.Property<int>("AssistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aeroporto")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("Aircraft")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("CheckIn")
                        .HasMaxLength(10);

                    b.Property<string>("Equipamentos")
                        .HasMaxLength(250);

                    b.Property<string>("Exit")
                        .HasMaxLength(1);

                    b.Property<string>("Gate")
                        .HasMaxLength(5);

                    b.Property<DateTime>("HoraContacto");

                    b.Property<DateTime>("HoraFim");

                    b.Property<DateTime>("HoraInicio");

                    b.Property<DateTime>("HoraVoo");

                    b.Property<string>("Movimento")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("NomePax")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Notificacao")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("OrigemDestino")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Stand")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("TipoMensagem")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Tipologia")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Transferencia")
                        .HasMaxLength(1);

                    b.Property<string>("Voo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("AssistenciaId");

                    b.ToTable("Assistencias");
                });

            modelBuilder.Entity("MyWayRazor.Models.BolsaHoras", b =>
                {
                    b.Property<int>("BolsaHorasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BolsaHorasData");

                    b.Property<int>("BolsaHorasHoras");

                    b.Property<int>("BolsaHorasMinutos");

                    b.Property<byte[]>("BolsaHorasTipo");

                    b.Property<int>("ColaboradorId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("BolsaHorasId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("BolsasHoras");
                });

            modelBuilder.Entity("MyWayRazor.Models.CargaHoraria", b =>
                {
                    b.Property<int>("CargaHorariaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CargaHorariaDescricao");

                    b.Property<int>("CargaHorariaHoras");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("CargaHorariaId");

                    b.ToTable("CargasHorarias");
                });

            modelBuilder.Entity("MyWayRazor.Models.CentroCusto", b =>
                {
                    b.Property<int>("CentroCustoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CentroCustoNome");

                    b.Property<int>("CentroCustoNum");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("CentroCustoId");

                    b.ToTable("CentrosCusto");
                });

            modelBuilder.Entity("MyWayRazor.Models.Colaborador", b =>
                {
                    b.Property<int>("ColaboradorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int?>("StatusID");

                    b.Property<int?>("UhID");

                    b.HasKey("ColaboradorID");

                    b.HasIndex("StatusID");

                    b.HasIndex("UhID");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("MyWayRazor.Models.Contrato", b =>
                {
                    b.Property<int>("ContratoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContratoNome");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("ContratoId");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("MyWayRazor.Models.DadosPessoais", b =>
                {
                    b.Property<int>("DadosPessoaisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColaboradorId");

                    b.Property<string>("ColaboradorIdentificacao");

                    b.Property<DateTime?>("ColaboradorIdentificacaoValidade");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("DadosPessoaisMorada");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("DadosPessoaisId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("DadosPessoais");
                });

            modelBuilder.Entity("MyWayRazor.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("DadosPessoaisId");

                    b.Property<string>("EmailEmail");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("EmailId");

                    b.HasIndex("DadosPessoaisId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("MyWayRazor.Models.Fatura", b =>
                {
                    b.Property<int>("FaturaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CentroCustoId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("FaturaNum");

                    b.Property<byte[]>("FaturaTipo");

                    b.Property<decimal>("FaturaValor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FornecedorId");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("FaturaId");

                    b.HasIndex("CentroCustoId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Faturas");
                });

            modelBuilder.Entity("MyWayRazor.Models.Formacao", b =>
                {
                    b.Property<int>("FormacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("FormacaoNome");

                    b.Property<int>("FormacaoValidade");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("FormacaoId");

                    b.ToTable("Formacoes");
                });

            modelBuilder.Entity("MyWayRazor.Models.FormacaoColaborador", b =>
                {
                    b.Property<int>("FormacaoColaboradorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColaboradorId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("FormacaoCaducidade");

                    b.Property<DateTime>("FormacaoData");

                    b.Property<int>("FormacaoId");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("FormacaoColaboradorId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("FormacaoId");

                    b.ToTable("FormacoesColaboradores");
                });

            modelBuilder.Entity("MyWayRazor.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int?>("FornecedorContribuinte");

                    b.Property<string>("FornecedorMorada");

                    b.Property<string>("FornecedorNome");

                    b.Property<int?>("FornecedorTelefone");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("MyWayRazor.Models.Observacao", b =>
                {
                    b.Property<int>("ObservacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColaboradorId");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("ObservacaoTitulo");

                    b.Property<string>("Texto");

                    b.HasKey("ObservacaoId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("MyWayRazor.Models.Resumo", b =>
                {
                    b.Property<int>("ResumoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtrasosAceites");

                    b.Property<int>("AtrasosImputados");

                    b.Property<DateTime>("DataResumo");

                    b.Property<int>("EquipamentosInopAmbulift");

                    b.Property<int>("EquipamentosInopVta");

                    b.Property<int>("EquipamentosOkAmbulift");

                    b.Property<int>("EquipamentosOkVta");

                    b.Property<int>("IncumprimentosSla");

                    b.Property<int>("StaffDuty");

                    b.Property<int>("StaffEscala");

                    b.Property<int>("TotalAssistencias");

                    b.Property<int>("TotalVoos");

                    b.HasKey("ResumoId");

                    b.ToTable("Resumos");
                });

            modelBuilder.Entity("MyWayRazor.Models.Sla", b =>
                {
                    b.Property<int>("SlaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("C90Maior15MenorIgual20");

                    b.Property<int>("C90Maior20MenorIgual30");

                    b.Property<int>("C90Maior30");

                    b.Property<int>("C90MenorIgual15");

                    b.Property<int>("CcMaior10MenorIgual20");

                    b.Property<int>("CcMaior20");

                    b.Property<int>("CcMaior5MenorIgual10");

                    b.Property<int>("CcMenorIgual5");

                    b.Property<int>("CsMaior25MenorIgual35");

                    b.Property<int>("CsMaior35MenorIgual45");

                    b.Property<int>("CsMaior45");

                    b.Property<int>("CsMenorIgual25");

                    b.Property<DateTime>("DataSla");

                    b.Property<int>("PcMaior10MenorIgual20");

                    b.Property<int>("PcMaior20MenorIgual30");

                    b.Property<int>("PcMaior30");

                    b.Property<int>("PcMenorIgual10");

                    b.Property<int>("PsMaior25MenorIgual35");

                    b.Property<int>("PsMaior35MenorIgual45");

                    b.Property<int>("PsMaior45");

                    b.Property<int>("PsMenorIgual25");

                    b.HasKey("SlaId");

                    b.ToTable("Slas");
                });

            modelBuilder.Entity("MyWayRazor.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Statuses")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("MyWayRazor.Models.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("DadosPessoaisId");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("TelefoneNumero");

                    b.HasKey("TelefoneId");

                    b.HasIndex("DadosPessoaisId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("MyWayRazor.Models.Uh", b =>
                {
                    b.Property<int>("UhID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("IATA")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("UhNome")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("UhID");

                    b.ToTable("Uh");
                });

            modelBuilder.Entity("MyWayRazor.Models.VinculoLaboral", b =>
                {
                    b.Property<int>("VinculoLaboralId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargaHorariaId");

                    b.Property<DateTime?>("CartaoValidade");

                    b.Property<int?>("CentroCustoId");

                    b.Property<int>("ColaboradorId");

                    b.Property<DateTime?>("ContratoFim");

                    b.Property<int>("ContratoId");

                    b.Property<DateTime?>("ContratoInicio");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<int?>("NumCartao");

                    b.Property<int?>("NumPw");

                    b.HasKey("VinculoLaboralId");

                    b.HasIndex("CargaHorariaId");

                    b.HasIndex("CentroCustoId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("ContratoId");

                    b.ToTable("VinculosLaborais");
                });

            modelBuilder.Entity("MyWayRazor.Models.BolsaHoras", b =>
                {
                    b.HasOne("MyWayRazor.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.Colaborador", b =>
                {
                    b.HasOne("MyWayRazor.Models.Status", "Status")
                        .WithMany("Colaboradores")
                        .HasForeignKey("StatusID");

                    b.HasOne("MyWayRazor.Models.Uh", "Uh")
                        .WithMany("Colaboradores")
                        .HasForeignKey("UhID");
                });

            modelBuilder.Entity("MyWayRazor.Models.DadosPessoais", b =>
                {
                    b.HasOne("MyWayRazor.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.Email", b =>
                {
                    b.HasOne("MyWayRazor.Models.DadosPessoais", "DadosPessoais")
                        .WithMany("Emails")
                        .HasForeignKey("DadosPessoaisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.Fatura", b =>
                {
                    b.HasOne("MyWayRazor.Models.CentroCusto", "CentroCusto")
                        .WithMany("Faturas")
                        .HasForeignKey("CentroCustoId");

                    b.HasOne("MyWayRazor.Models.Fornecedor", "Fornecedor")
                        .WithMany("Faturas")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.FormacaoColaborador", b =>
                {
                    b.HasOne("MyWayRazor.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyWayRazor.Models.Formacao", "Formacao")
                        .WithMany("FormacoesColaborador")
                        .HasForeignKey("FormacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.Observacao", b =>
                {
                    b.HasOne("MyWayRazor.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.Telefone", b =>
                {
                    b.HasOne("MyWayRazor.Models.DadosPessoais", "DadosPessoais")
                        .WithMany("Telefones")
                        .HasForeignKey("DadosPessoaisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyWayRazor.Models.VinculoLaboral", b =>
                {
                    b.HasOne("MyWayRazor.Models.CargaHoraria", "CargaHoraria")
                        .WithMany("VinculoLaboral")
                        .HasForeignKey("CargaHorariaId");

                    b.HasOne("MyWayRazor.Models.CentroCusto", "CentroCusto")
                        .WithMany("VinculoLaboral")
                        .HasForeignKey("CentroCustoId");

                    b.HasOne("MyWayRazor.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyWayRazor.Models.Contrato", "Contrato")
                        .WithMany("VinculoLaboral")
                        .HasForeignKey("ContratoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
