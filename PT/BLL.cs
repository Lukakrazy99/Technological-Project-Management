using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public class Inicio
        {
            static public object contarclientes()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select COUNT (nome) from Clientes", sqlParams);
            }
            static public object contarfuncionarios()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select COUNT (nome) from Funcionarios", sqlParams);
            }
            static public object contarVeiculos()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select COUNT (matricula) from veiculos", sqlParams);
            }
            static public object contarVeiculosv2()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select COUNT (matricula) from veiculos where Ativo = 'Sim'", sqlParams);
            }
            static public object contarVender()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select COUNT (Id_Funcionario) from Vendas", sqlParams);
            }
            static public object contarAlugar()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select COUNT (Id_Clientes) from Alugueres", sqlParams);
            }
        }
        public class Funcionarios
        {

            static public DataTable queryValidaçaoNIBed(int Id_Funcionario, string NIB)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@Id_Funcionario", Id_Funcionario),
                 new SqlParameter("@NIB", NIB)
                };
                return dal.executarReader("select * from Funcionarios where Id_Funcionario<>@Id_Funcionario and NIB=@NIB", sqlParams);
            }
            static public DataTable queryValidaçaoNIFed(int Id_Funcionario, int NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                new SqlParameter("@NIF", NIF)
                };
                return dal.executarReader("select * from Funcionarios where Id_Funcionario<>@Id_Funcionario and NIF=@NIF", sqlParams);
            }
            static public DataTable queryValidaçaoCCed(int Id_Funcionario, string CC)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                 new SqlParameter("@CC", CC)
                };
                return dal.executarReader("select * from Funcionarios where Id_Funcionario<>@Id_Funcionario and CC=@CC", sqlParams);
            }
            static public DataTable queryValidaçaoTelemoveled(int Id_Funcionario, int Telemovel)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                 new SqlParameter("@Telemovel", Telemovel)
                };
                return dal.executarReader("select * from Funcionarios where Id_Funcionario<>@Id_Funcionario and Telemovel=@Telemovel", sqlParams);
            }
            static public DataTable queryValidaçaoNIF(int NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NIF", NIF)
                };
                return dal.executarReader("select * from Funcionarios where NIF=@NIF", sqlParams);
            }
            static public DataTable queryValidaçaoNIB(string NIB)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                 new SqlParameter("@NIB", NIB)
                };
                return dal.executarReader("select * from Funcionarios where NIB=@NIB", sqlParams);
            }
            static public DataTable queryValidaçaoCC(string CC)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                 new SqlParameter("@CC", CC)
                };
                return dal.executarReader("select * from Funcionarios where CC=@CC", sqlParams);
            }
            static public DataTable queryValidaçaoTelemovel(int Telemovel)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                 new SqlParameter("@Telemovel", Telemovel)
                };
                return dal.executarReader("select * from Funcionarios where Telemovel=@Telemovel", sqlParams);
            }

            static public DataTable querylogin(int NIF, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NIF", NIF),
                 new SqlParameter("@Senha", Senha)
                };
                return dal.executarReader("select * from Funcionarios where NIF=@NIF and Senha=@Senha", sqlParams);
            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Funcionarios", null);
            }
            static public int insertFuncionario(string Nome, string CC, string NIB, int NIF, int Telemovel, string Email, string Morada, string Cod_Postal, DateTime Data_de_Nascimento, string Certificacao, string Cargo, string Senha, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Nome", Nome),
                new SqlParameter("@CC", CC),
                new SqlParameter("@NIB", NIB),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@Telemovel", Telemovel),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Cod_Postal", Cod_Postal),
                new SqlParameter("@Data_de_Nascimento", Data_de_Nascimento),
                new SqlParameter("@Certificacao", Certificacao),
                new SqlParameter("@Cargo", Cargo),
                new SqlParameter("@Senha", Senha),
                new SqlParameter("@Ativo", Ativo)

           };

                return dal.executarNonQuery("INSERT into Funcionarios (Nome, CC, NIB, NIF, Telemovel, Email, Morada, Cod_Postal, Data_de_Nascimento, Certificacao, Cargo, Senha, Ativo) VALUES(@Nome, @CC,@NIB,@NIF,@Telemovel,@Email,@Morada,@Cod_Postal,@Data_de_Nascimento,@Certificacao,@Cargo,@Senha,@Ativo)", sqlParams);
            }
            static public int updateFuncionario(string Id_Funcionario, string Nome, string CC, string NIB, int NIF, int Telemovel, string Email, string Morada, string Cod_Postal, DateTime Data_de_Nascimento, string Certificacao, string Cargo, string Senha, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@CC", CC),
                new SqlParameter("@NIB", NIB),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@Telemovel", Telemovel),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Cod_Postal", Cod_Postal),
                new SqlParameter("@Data_de_Nascimento", Data_de_Nascimento),
                new SqlParameter("@Certificacao", Certificacao),
                new SqlParameter("@Cargo", Cargo),
                new SqlParameter("@Senha", Senha),
                new SqlParameter("@Ativo", Ativo)
            };
                return dal.executarNonQuery("update [Funcionarios] set [Nome]=@Nome, [CC]=@CC, [NIB]=@NIB, [NIF]=@NIF, [Telemovel]=@Telemovel, [Email]=@Email, [Morada]=@Morada, [Cod_Postal]=@Cod_Postal, [Data_de_Nascimento]=@Data_de_Nascimento, [Certificacao]=@Certificacao, [Cargo]=@Cargo, [Senha]=@Senha, [Ativo]=@Ativo where [Id_Funcionario]=@Id_Funcionario ", sqlParams);
            }
            static public DataTable queryFuncionario_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select * from Funcionarios where Nome like @dados or CC like @dados or NIF like @dados or Telemovel like @dados or Email like @dados or Morada like @dados or Cod_Postal like @dados  or Data_de_Nascimento like @dados or Certificacao like @dados or Senha like @dados", sqlParams);
            }
        }
        public class Clientes
        {
            static public int insertClientes(string Nome, string CC, int NIF, string Morada, int Telemovel, string Email, string Cod_Postal, DateTime Data_de_Nascimento, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@CC", CC),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Telemovel", Telemovel),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Cod_Postal", Cod_Postal),
                new SqlParameter("@Data_de_Nascimento", Data_de_Nascimento),
                new SqlParameter("@Ativo", Ativo)

           };

                return dal.executarNonQuery("INSERT into Clientes (Nome, CC, NIF, Morada, Telemovel, Email,  Cod_Postal, Data_de_Nascimento, Ativo) VALUES(@Nome, @CC, @NIF, @Morada, @Telemovel, @Email,  @Cod_Postal, @Data_de_Nascimento, @Ativo)", sqlParams);
            }
            static public int updateClientes(int Id_Clientes, string Nome, string CC, int NIF, string Morada, int Telemovel, string Email, string Cod_Postal, DateTime Data_de_Nascimento, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@CC", CC),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Telemovel", Telemovel),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Cod_Postal", Cod_Postal),
                new SqlParameter("@Data_de_Nascimento", Data_de_Nascimento),
                new SqlParameter("@Ativo", Ativo)

           };

                return dal.executarNonQuery("update [Clientes] set [Nome]=@Nome, [CC]=@CC, [NIF]=@NIF, [Morada]=@Morada, [Telemovel]=@Telemovel, [Email]=@Email, [Cod_Postal]=@Cod_Postal, [Data_de_Nascimento]=@Data_de_Nascimento, [Ativo]=@Ativo where [Id_Clientes]=@Id_Clientes ", sqlParams);
            }
            static public DataTable queryClientes_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select * from Clientes where Id_Clientes like @dados or Nome like @dados or Email like @dados or CC like @dados or NIF like @dados or Data_de_Nascimento like @dados or Morada like @dados  or Cod_Postal like @dados  or Telemovel like @dados or Ativo like @dados", sqlParams);
            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Clientes", null);

            }
            static public DataTable queryValidaçaoNIFed(int Id_Clientes, int NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@NIF", NIF)
                };
                return dal.executarReader("select * from Clientes where Id_Clientes<>@Id_Clientes and NIF=@NIF", sqlParams);
            }

            static public DataTable queryValidaçaoCCed(int Id_Clientes, string CC)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@Id_Clientes", Id_Clientes),
                 new SqlParameter("@CC", CC)
                };
                return dal.executarReader("select * from Clientes where Id_Clientes<>@Id_Clientes and CC=@CC", sqlParams);
            }

            static public DataTable queryValidaçaoTelemoveled(int Id_Clientes, int Telemovel)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@Id_Clientes", Id_Clientes),
                 new SqlParameter("@Telemovel", Telemovel)
                };
                return dal.executarReader("select * from Clientes where Id_Clientes<>@Id_Clientes and Telemovel=@Telemovel", sqlParams);
            }

            static public DataTable queryValidaçaoNIF(int NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NIF", NIF)
                };
                return dal.executarReader("select * from Clientes where NIF=@NIF", sqlParams);
            }

            static public DataTable queryValidaçaoCC(string CC)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                 new SqlParameter("@CC", CC)
                };
                return dal.executarReader("select * from Clientes where CC=@CC", sqlParams);
            }

            static public DataTable queryValidaçaoTelemovel(int Telemovel)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                 new SqlParameter("@Telemovel", Telemovel)
                };
                return dal.executarReader("select * from Clientes where Telemovel=@Telemovel", sqlParams);
            }


        }
        public class Veiculos
        {
            static public int insertVeiculos(string Matricula, string Marca, string Modelo, string Categoria, int Quilometros, string Combustível, int Ano, string Cor, int Cilindrada, int Potencia, DateTime Inspecao, DateTime Revisao, DateTime Seguro, string Ativo, string Alugar, string Vender, int Preco)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Matricula", Matricula),
                new SqlParameter("@Marca", Marca),
                new SqlParameter("@Modelo", Modelo),
                new SqlParameter("@Categoria", Categoria),
                new SqlParameter("@Quilometros", Quilometros),
                new SqlParameter("@Combustível", Combustível),
                new SqlParameter("@Ano", Ano),
                new SqlParameter("@Cor", Cor),
                new SqlParameter("@Cilindrada", Cilindrada),
                new SqlParameter("@Potencia", Potencia),
                new SqlParameter("@Inspecao", Inspecao),
                new SqlParameter("@Revisao", Revisao),
                new SqlParameter("@Seguro", Seguro),
                new SqlParameter("@Ativo", Ativo),
                new SqlParameter("@Alugar", Alugar),
                new SqlParameter("@Vender", Vender),
                new SqlParameter("@Preco", Preco)
           };

                return dal.executarNonQuery("INSERT into Veiculos (Matricula, Marca, Modelo, Categoria, Quilometros, Combustível, Ano, Cor, Cilindrada, Potencia, Inspecao, Revisao, Seguro, Ativo, Alugar, Vender, Preco) VALUES(@Matricula, @Marca, @Modelo, @Categoria, @Quilometros, @Combustível, @Ano, @Cor, @Cilindrada, @Potencia, @Inspecao, @Revisao, @Seguro, @Ativo, @Alugar, @Vender,@Preco)", sqlParams);
            }
            static public int updateVeiculos(int Id_Veiculo, string Matricula, string Marca, string Modelo, string Categoria, int Quilometros, string Combustível, int Ano, string Cor, int Cilindrada, int Potencia, DateTime Inspecao, DateTime Revisao, DateTime Seguro, string Ativo, string Alugar, string Vender, int Preco)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo),
                new SqlParameter("@Matricula", Matricula),
                new SqlParameter("@Marca", Marca),
                new SqlParameter("@Modelo", Modelo),
                new SqlParameter("@Categoria", Categoria),
                new SqlParameter("@Quilometros", Quilometros),
                new SqlParameter("@Combustível", Combustível),
                new SqlParameter("@Ano", Ano),
                new SqlParameter("@Cor", Cor),
                new SqlParameter("@Cilindrada", Cilindrada),
                new SqlParameter("@Potencia", Potencia),
                new SqlParameter("@Inspecao", Inspecao),
                new SqlParameter("@Revisao", Revisao),
                new SqlParameter("@Seguro", Seguro),
                new SqlParameter("@Ativo", Ativo),
                new SqlParameter("@Alugar", Alugar),
                new SqlParameter("@Vender", Vender),
                new SqlParameter("@Preco", Preco)
           };

                return dal.executarNonQuery("update [Veiculos] set [Matricula]=@Matricula, [Marca]=@Marca, [Modelo]=@Modelo, [Categoria]=@Categoria, [Quilometros]=@Quilometros, [Combustível]=@Combustível, [Ano]=@Ano, [Cor]=@Cor, [Cilindrada]=@Cilindrada, [Potencia]=@Potencia, [Inspecao]=@Inspecao, [Revisao]=@Revisao, [Seguro]=@Seguro, [Ativo]=@Ativo, [Alugar]=@Alugar, [Vender]=@Vender, [Preco]=@Preco  where [Id_Veiculo]=@Id_Veiculo", sqlParams);
            }
            static public DataTable queryValidaçaoMatriculaed(string Matricula, string Id_Veiculo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                 new SqlParameter("@Id_Veiculo", Id_Veiculo),
                 new SqlParameter("@Matricula", Matricula)
                };
                return dal.executarReader("select * from Veiculos where Id_Veiculo <> @Id_Veiculo and Matricula=@Matricula", sqlParams);
            }
            static public DataTable queryVeiculo_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select * from Veiculos where Matricula like @dados or Marca like @dados or Modelo like @dados or Categoria like @dados or Quilometros like @dados or Combustível like @dados or Ano like @dados  or Cor like @dados or Cilindrada like @dados or Potencia like @dados or Inspecao like @dados or Revisao like @dados or Seguro like @dados or Ativo like @dados", sqlParams);
            }
            static public DataTable queryValidaçaoMatricula(string Matricula)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                 new SqlParameter("@Matricula", Matricula)
                };
                return dal.executarReader("select * from Veiculos where Matricula=@Matricula", sqlParams);
            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Veiculos", null);
            }
        }
        public class Login
        {
            static public DataTable Entrar1(int Id_Funcionario, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                new SqlParameter("@Senha", Senha)
           };

                return dal.executarReader("Select * FROM Funcionarios where Id_Funcionario=@Id_Funcionario AND Senha=@Senha", sqlParams);
            }
            static public DataTable Entrar(string NIF, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@Senha", Senha)
           };

                return dal.executarReader("Select * FROM Funcionarios where NIF=@NIF AND Senha=@Senha", sqlParams);
            }
            static public int updateLogin(int Id_Funcionario, string Senha)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                new SqlParameter("@Senha", Senha)

                };
                return dal.executarNonQuery("update [Funcionarios] set [Senha]=@Senha where Id_Funcionario=@Id_Funcionario", sqlParams);
            }
        }
        public class Vender
        {

            static public object nome(int Id_Clientes)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                };
                return dal.executarScalar("select Nome from Clientes where Id_Clientes=@Id_Clientes", sqlParams);

            }
            static public DataTable queryVender_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select * from Vendas where Id_Clientes like @dados or Id_Funcionario like @dados or Id_Veiculo like @dados or Data_Contrato like @dados or Preco like @dados ", sqlParams);
            }
            static public int removeVendas(int Id_Vendas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Vendas", Id_Vendas)
           };

                return dal.executarNonQuery("DELETE FROM Vendas where (@Id_Vendas = Id_Vendas)", sqlParams);
            }
            static public int removeVendas2(int Id_Vendas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Vendas", Id_Vendas)
           };

                return dal.executarNonQuery("DELETE FROM Vendas2 where (@Id_Vendas = Id_Vendas)", sqlParams);
            }

            static public int insertVendas(int Id_Funcionario, DateTime Data_Contrato, int Preco, int Id_Clientes)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                new SqlParameter("@Data_Contrato", Data_Contrato),
                new SqlParameter("@Preco", Preco)

           };

                return dal.executarNonQuery("INSERT into Vendas (Id_Clientes,Id_Funcionario, Data_Contrato, Preco) VALUES(@Id_Clientes,@Id_Funcionario, @Data_Contrato, @Preco)", sqlParams);
            }
            static public object queryMaxid()
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Id_Vendas", "Id_Vendas")

                };

                return dal.executarScalar("select Max (Id_Vendas) from Vendas ", sqlParams);

            }
            static public DataTable procurar(int Id_Vendas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Vendas",  Id_Vendas),

            };
                return dal.executarReader("select * from Vendas where Id_Vendas=@Id_Vendas", sqlParams);
            }

            static public object Id(int Id_Veiculo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo),
                };
                return dal.executarScalar("select Preco from Veiculos where Id_Veiculo=@Id_Veiculo", sqlParams);

            }

            static public int updateVendas(int Id_Vendas, int Id_Clientes, int Id_Funcionario, DateTime Data_Contrato, int Preco)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Vendas", Id_Vendas),
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Id_Funcionario", Id_Funcionario),
                new SqlParameter("@Data_Contrato", Data_Contrato),
                new SqlParameter("@Preco", Preco)
           };

                return dal.executarNonQuery("update [Vendas] set  [Id_Clientes]=@Id_Clientes,[Id_Funcionario]=@Id_Funcionario, [Data_Contrato]=@Data_Contrato, [Preco]=@Preco where [Id_Vendas]=@Id_Vendas", sqlParams);
            }

            static public int updateAtivo(int Id_Veiculo, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo),
                new SqlParameter("@Ativo", Ativo),
           };

                return dal.executarNonQuery("update [Vendas] set [Id_Veiculo]=@Id_Veiculo, [Ativo]=@Ativo where [Id_Veiculo]=@Id_Veiculo", sqlParams);
            }

            static public int updateVeiculos(int Id_Veiculo, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo),
                new SqlParameter("@Ativo", Ativo)

           };

                return dal.executarNonQuery("update [Veiculos] set [Ativo]=@Ativo where [Id_Veiculo]=@Id_Veiculo", sqlParams);
            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarReader("select * from Vendas  ", null);
            }
            static public DataTable Loadvendas()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Veiculos where Vender = 'Sim' AND Ativo = 'Sim'  ", null);
            }

            static public object Loadvendased(int Id_Veiculo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo)
                };


                return dal.executarReader("select * from Veiculos where Vender = 'Sim' and Ativo = 'Sim' or [Id_Veiculo]=@Id_Veiculo  ", sqlParams);
            }
            static public DataTable queryVeiculo_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select * from Vendas where Id_Funcionario like @dados or Id_Veiculo like @dados or Data_Venda_Inicio like @dados or Id_Clientes like @dados or Data_Venda_Fim like @dados or Preco like @dados", sqlParams);
            }
        }
        public class Vender2
        {
            static public int removeVendas2(int Id_Veiculo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo)
           };

                return dal.executarNonQuery("DELETE FROM Vendas2 where (@Id_Veiculo = Id_Veiculo)", sqlParams);
            }
            static public int updateVendas2_1(int Id_Clientes, int Id_Vendas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Id_Vendas", Id_Vendas)
           };

                return dal.executarNonQuery("update [Vendas2] set [Id_Clientes]=@Id_Clientes where [Id_Vendas]=@Id_Vendas", sqlParams);
            }
            static public int InsertVender2(int Id_Vendas, int Id_Veiculo, int Id_Clientes)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                      new SqlParameter("@Id_Vendas", Id_Vendas),
                      new SqlParameter("@Id_Veiculo", Id_Veiculo),
                      new SqlParameter("@Id_Clientes", Id_Clientes),
                };

                return dal.executarNonQuery("INSERT into Vendas2 (Id_Vendas, Id_Veiculo, Id_Clientes) VALUES(@Id_Vendas,@Id_Veiculo,@Id_Clientes)", sqlParams);
            }
            static public int updateVender2(int Id_Vendas, int Id_Veiculo, int Id_Clientes)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                        new SqlParameter("@Id_Vendas", Id_Vendas),
                      new SqlParameter("@Id_Veiculo", Id_Veiculo),
                      new SqlParameter("@Id_Clientes", Id_Clientes),

                };

                return dal.executarNonQuery("update [Vendas2] set [Id_Veiculo]=@Id_Veiculo, [Id_Clientes]=@Id_Clientes where [Id_Vendas]=@Id_Vendas", sqlParams);
            }
            static public object editarJogo1(int Id_Vendas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                    new SqlParameter("@Id_Vendas", Id_Vendas),

            };
                return dal.executarScalar("select Id_Veiculo from Vendas2 where Id_Vendas=@Id_Vendas", sqlParams);

            }
            static public DataTable editarJogo2(int Id_Vendas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                    new SqlParameter("@Id_Vendas", Id_Vendas),

            };
                return dal.executarReader("select * from Vendas2 where Id_Vendas=@Id_Vendas", sqlParams);

            }
        }
        public class Alugar
        {
            static public DataTable  datas()
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{

                

                };

                return dal.executarReader("select * from Alugueres ", sqlParams);

            }
            static public DataTable veiculos(DateTime Data_Aluguer_Inicio , DateTime Data_Aluguer_Fim)
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Data_Aluguer_Inicio", Data_Aluguer_Inicio),
                new SqlParameter("@Data_Aluguer_Fim", Data_Aluguer_Fim)
                

                };

                return dal.executarReader("Select * from Veiculos where Id_Veiculo in (Select Veiculos.Id_Veiculo from Veiculos full join Alugueres2 on (Veiculos.Id_Veiculo = Alugueres2.Id_Veiculo) full join Alugueres  on (Alugueres.Id_Alugueres = Alugueres2.Id_Alugueres) where @Data_Aluguer_Inicio  not between Alugueres.Data_Aluguer_Inicio and Alugueres.Data_Aluguer_Fim and @Data_Aluguer_Fim not between Alugueres.Data_Aluguer_Inicio and Alugueres.Data_Aluguer_Fim or (Veiculos.Ativo = 'Sim' and Veiculos.Alugar = 'Sim')  )", sqlParams);

            }
            static public object queryMaxid()
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{

               

                };

                return dal.executarScalar("select Max (Id_Alugueres) from Alugueres ", sqlParams);

            }
            static public DataTable procurar(int Id_Alugueres)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Alugueres",  Id_Alugueres),

            };
                return dal.executarReader("select * from Alugueres where Id_Alugueres=@Id_Alugueres", sqlParams);
            }
            static public DataTable queryAlugar_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select * from Alugueres where Id_Clientes like @dados or Id_Funcionario like @dados or Id_Veiculo like @dados or Data_Aluguer_Inicio like @dados or Data_Aluguer_Fim like @dados or Preco like @dados ", sqlParams);
            }
            static public object Loadvendased(int Id_Veiculo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo)
                };


                return dal.executarReader("select * from Veiculos where Alugar = 'Sim' and Ativo = 'Sim' or [Id_Veiculo]=@Id_Veiculo  ", sqlParams);
            }
            static public DataTable Loadalugar()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Veiculos where Alugar = 'Sim' AND Ativo = 'Sim'  ", null);
            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarReader("select * from Alugueres  ", null);
            }
            static public int removeAlugar(int Id_Alugueres)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Alugueres", Id_Alugueres)
           };

                return dal.executarNonQuery("DELETE FROM Alugueres where (@Id_Alugueres = Id_Alugueres)", sqlParams);
            }
            static public int insertAlugar(int Id_Clientes, int Id_Funcionario, DateTime Data_Aluguer_Inicio, DateTime Data_Aluguer_Fim, int Preco)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Id_Funcionario", Id_Funcionario),

                new SqlParameter("@Data_Aluguer_Inicio", Data_Aluguer_Inicio),
                new SqlParameter("@Data_Aluguer_Fim", Data_Aluguer_Fim),
                new SqlParameter("@Preco", Preco)

           };

                return dal.executarNonQuery("INSERT into Alugueres (Id_Clientes, Id_Funcionario, Data_Aluguer_Inicio, Data_Aluguer_Fim, Preco) VALUES(@Id_Clientes, @Id_Funcionario, @Data_Aluguer_Inicio, @Data_Aluguer_Fim, @Preco)", sqlParams);
            }
            static public int updateAlugar(int Id_Alugueres, int Id_Clientes, int Id_Funcionario, DateTime Data_Aluguer_Inicio, DateTime Data_Aluguer_Fim, int Preco)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@Id_Alugueres", Id_Alugueres),
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Id_Funcionario", Id_Funcionario),

                new SqlParameter("@Data_Aluguer_Inicio", Data_Aluguer_Inicio),
                new SqlParameter("@Data_Aluguer_Fim", Data_Aluguer_Fim),
                new SqlParameter("@Preco", Preco)
           };

                return dal.executarNonQuery("update [Alugueres] set [Id_Clientes]=@Id_Clientes, [Id_Funcionario]=@Id_Funcionario, [Data_Aluguer_Inicio]=@Data_Aluguer_Inicio, [Data_Aluguer_Fim]=@Data_Aluguer_Fim, [Preco]=@Preco where [Id_Alugueres]=@Id_Alugueres", sqlParams);
            }
            static public int updateVeiculos(int Id_Veiculo, string Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo),
                new SqlParameter("@Ativo", Ativo)

           };

                return dal.executarNonQuery("update [Veiculos] set [Ativo]=@Ativo where [Id_Veiculo]=@Id_Veiculo", sqlParams);
            }
        }
        public class Alugar2
        {
            static public int removeAlugar2(int Id_Veiculo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Veiculo", Id_Veiculo)
           };

                return dal.executarNonQuery("DELETE FROM Alugueres2 where (@Id_Veiculo = Id_Veiculo)", sqlParams);
            }
            static public int updateAlugar2_1(int Id_Clientes, int Id_Alugueres)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_Clientes", Id_Clientes),
                new SqlParameter("@Id_Alugueres", Id_Alugueres)
           };

                return dal.executarNonQuery("update [Alugueres2] set [Id_Clientes]=@Id_Clientes where [Id_Alugueres]=@Id_Alugueres", sqlParams);
            }
            static public int InsertAlugar2(int Id_Alugueres, int Id_Veiculo, int Id_Clientes)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                      new SqlParameter("@Id_Alugueres", Id_Alugueres),
                      new SqlParameter("@Id_Veiculo", Id_Veiculo),
                      new SqlParameter("@Id_Clientes", Id_Clientes),
                };

                return dal.executarNonQuery("INSERT into Alugueres2 (Id_Alugueres, Id_Veiculo, Id_Clientes) VALUES(@Id_Alugueres,@Id_Veiculo,@Id_Clientes)", sqlParams);
            }
            static public int updateAlugar2(int Id_Alugueres, int Id_Veiculo, int Id_Clientes)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                        new SqlParameter("@Id_Alugueres", Id_Alugueres),
                      new SqlParameter("@Id_Veiculo", Id_Veiculo),
                      new SqlParameter("@Id_Clientes", Id_Clientes),

                };

                return dal.executarNonQuery("update [Alugueres2] set [Id_Veiculo]=@Id_Veiculo, [Id_Clientes]=@Id_Clientes where [Id_Alugueres]=@Id_Alugueres", sqlParams);
            }
            static public object editarJogo1(int Id_Alugueres)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                    new SqlParameter("@Id_Alugueres", Id_Alugueres),

            };
                return dal.executarScalar("select Id_Veiculo from Alugueres2 where Id_Alugueres=@Id_Alugueres", sqlParams);

            }
            static public DataTable editarJogo2(int Id_Alugueres)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                    new SqlParameter("@Id_Alugueres", Id_Alugueres),

            };
                return dal.executarReader("select * from Alugueres2 where Id_Alugueres=@Id_Alugueres", sqlParams);

            }

        }
        public class ProcurarVender
        {


            static public DataTable vendasprocurarclientes_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Vendas2.Id_Vendas, Veiculos.Matricula, Clientes.Nome as Nome_Clientes, Funcionarios.Nome as Nome_Funcionário, Vendas.Preco, Vendas.Data_Contrato from Funcionarios inner join Vendas on (Funcionarios.Id_Funcionario = Vendas.Id_Funcionario) inner join Vendas2 on (Vendas2.Id_Vendas = Vendas.Id_Vendas) inner join Veiculos on (Vendas2.Id_Veiculo = Veiculos.Id_Veiculo) inner join Clientes on (Vendas2.Id_Clientes = Clientes.Id_Clientes) where Clientes.Id_Clientes like @dados or Clientes.Nome like @dados or Clientes.Email like @dados or Clientes.CC like @dados or Clientes.NIF like @dados or Clientes.Data_de_Nascimento like @dados or Clientes.Morada like @dados  or Clientes.Cod_Postal like @dados  or Clientes.Telemovel like @dados or Clientes.Ativo like @dados", sqlParams);
            }
            static public DataTable vendasprocurarfuncionario_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Alugueres2.Id_Alugueres, Veiculos.Matricula, Clientes.Nome as Nome_Clientes, Funcionarios.Nome as Nome_Funcionário, Alugueres.Preco, Alugueres.Data_Aluguer_Inicio, Alugueres.Data_Aluguer_Fim  from Funcionarios inner join Alugueres on (Funcionarios.Id_Funcionario = Alugueres.Id_Funcionario) inner join Alugueres2 on (Alugueres2.Id_Alugueres = Alugueres.Id_Alugueres) inner join Veiculos on (Alugueres2.Id_Veiculo = Veiculos.Id_Veiculo) inner join Clientes on (Alugueres2.Id_Clientes = Clientes.Id_Clientes) where Funcionarios.Id_Funcionario like @dados or Funcionarios.Nome like @dados or Funcionarios.Telemovel like @dados or Funcionarios.Email like @dados or Funcionarios.Data_de_Nascimento like @dados or Funcionarios.Cargo like @dados or Funcionarios.Ativo like @dados", sqlParams);
            }
            static public DataTable queryFuncionario_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Id_Funcionario, Nome, Telemovel, Email, Data_de_Nascimento, Cargo, Ativo  from Funcionarios where Id_Funcionario like @dados or Nome like @dados or Telemovel like @dados or Email like @dados or Data_de_Nascimento like @dados or Cargo like @dados or Ativo like @dados  ", sqlParams);
            }
            static public DataTable vendasprocurarveiculo_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Vendas2.Id_Vendas, Veiculos.Matricula, Clientes.Nome as Nome_Clientes, Funcionarios.Nome, Vendas.Preco, Vendas.Data_Contrato as Nome_Funcionário from Funcionarios inner join Vendas on (Funcionarios.Id_Funcionario = Vendas.Id_Funcionario) inner join Vendas2 on (Vendas2.Id_Vendas = Vendas.Id_Vendas) inner join Veiculos on (Vendas2.Id_Veiculo = Veiculos.Id_Veiculo) inner join Clientes on (Vendas2.Id_Clientes = Clientes.Id_Clientes) where  Veiculos.Matricula like @dados or Veiculos.Marca like @dados or Veiculos.Modelo like @dados or Veiculos.Categoria like @dados or Veiculos.Quilometros like @dados or Veiculos.Combustível like @dados or Veiculos.Ano like @dados  or Veiculos.Cor like @dados or Veiculos.Cilindrada like @dados or Veiculos.Potencia like @dados or Veiculos.Inspecao like @dados or Veiculos.Revisao like @dados or Veiculos.Seguro like @dados or Veiculos.Ativo like @dados and Vender = 'Sim'", sqlParams);
            }
        }
        public class ProcurarAlugar
        {
            static public DataTable vendasprocurarclientes_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Alugueres2.Id_Alugueres, Veiculos.Matricula, Clientes.Nome as Nome_Clientes, Funcionarios.Nome as Nome_Funcionário, Alugueres.Preco, Alugueres.Data_Aluguer_Inicio, Alugueres.Data_Aluguer_Fim  from Funcionarios inner join Alugueres on (Funcionarios.Id_Funcionario = Alugueres.Id_Funcionario) inner join Alugueres2 on (Alugueres2.Id_Alugueres = Alugueres.Id_Alugueres) inner join Veiculos on (Alugueres2.Id_Veiculo = Veiculos.Id_Veiculo) inner join Clientes on (Alugueres2.Id_Clientes = Clientes.Id_Clientes) where Clientes.Id_Clientes like @dados or Clientes.Nome like @dados or Clientes.Email like @dados or Clientes.CC like @dados or Clientes.NIF like @dados or Clientes.Data_de_Nascimento like @dados or Clientes.Morada like @dados  or Clientes.Cod_Postal like @dados  or Clientes.Telemovel like @dados or Clientes.Ativo like @dados", sqlParams);
            }
            static public DataTable vendasprocurarfuncionario_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Alugueres2.Id_Alugueres, Veiculos.Matricula, Clientes.Nome as Nome_Clientes, Funcionarios.Nome as Nome_Funcionário, Alugueres.Preco, Alugueres.Data_Aluguer_Inicio, Alugueres.Data_Aluguer_Fim  from Funcionarios inner join Alugueres on (Funcionarios.Id_Funcionario = Alugueres.Id_Funcionario) inner join Alugueres2 on (Alugueres2.Id_Alugueres = Alugueres.Id_Alugueres) inner join Veiculos on (Alugueres2.Id_Veiculo = Veiculos.Id_Veiculo) inner join Clientes on (Alugueres2.Id_Clientes = Clientes.Id_Clientes) where Funcionarios.Id_Funcionario like @dados or Funcionarios.Nome like @dados or Funcionarios.Telemovel like @dados or Funcionarios.Email like @dados or Funcionarios.Data_de_Nascimento like @dados or Funcionarios.Cargo like @dados or Funcionarios.Ativo like @dados", sqlParams);
            }
            static public DataTable queryFuncionario_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Id_Funcionario, Nome, Telemovel, Email, Data_de_Nascimento, Cargo, Ativo  from Funcionarios where Id_Funcionario like @dados or Nome like @dados or Telemovel like @dados or Email like @dados or Data_de_Nascimento like @dados or Cargo like @dados or Ativo like @dados  ", sqlParams);
            }
            static public DataTable vendasprocurarveiculo_Like(String dados)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@dados", dados + "%")
                };
                return dal.executarReader("select Alugueres2.Id_Alugueres, Veiculos.Matricula, Clientes.Nome as Nome_Clientes, Funcionarios.Nome as Nome_Funcionário, Alugueres.Preco, Alugueres.Data_Aluguer_Inicio, Alugueres.Data_Aluguer_Fim  from Funcionarios inner join Alugueres on (Funcionarios.Id_Funcionario = Alugueres.Id_Funcionario) inner join Alugueres2 on (Alugueres2.Id_Alugueres = Alugueres.Id_Alugueres) inner join Veiculos on (Alugueres2.Id_Veiculo = Veiculos.Id_Veiculo) inner join Clientes on (Alugueres2.Id_Clientes = Clientes.Id_Clientes) where  Veiculos.Matricula like @dados or Veiculos.Marca like @dados or Veiculos.Modelo like @dados or Veiculos.Categoria like @dados or Veiculos.Quilometros like @dados or Veiculos.Combustível like @dados or Veiculos.Ano like @dados  or Veiculos.Cor like @dados or Veiculos.Cilindrada like @dados or Veiculos.Potencia like @dados or Veiculos.Inspecao like @dados or Veiculos.Revisao like @dados or Veiculos.Seguro like @dados or Veiculos.Ativo like @dados and Vender = 'Sim'", sqlParams);
            }
        }
        public class Marca_Modelo
        {
            static public int insertmarca(string Marca)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@Marca", Marca)

           };

                return dal.executarNonQuery("INSERT into Marca_Modelo (Marca) VALUES(@Marca) ", sqlParams);
            }
            static public int insertmodelo(string Marca, string Modelo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Marca", Marca),
                new SqlParameter("@Modelo", Modelo)

           };

                return dal.executarNonQuery("INSERT into Marca_Modelo (Marca, Modelo) VALUES(@Marca, @Modelo)", sqlParams);
            }
            static public DataTable marca()
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{



                };

                return dal.executarReader("SELECT DISTINCT Marca  from Marca_Modelo Order by Marca Asc", sqlParams);

            }
            static public DataTable marca1(string Marca)
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{
                     new SqlParameter("@Marca", Marca)


                };

                return dal.executarReader("SELECT DISTINCT Marca  from Marca_Modelo where Marca = @Marca Order by Marca Asc", sqlParams);

            }

            static public DataTable modelo(string Marca)
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{

                     new SqlParameter("@Marca", Marca)

                };

                return dal.executarReader("SELECT DISTINCT Modelo from Marca_Modelo where Marca = @Marca and Modelo is not null Order by Modelo Asc", sqlParams);

            }
            static public DataTable modelo1(string Marca, string Modelo)
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{

                      new SqlParameter("@Marca", Marca),
                new SqlParameter("@Modelo", Modelo)
                };

                return dal.executarReader("SELECT DISTINCT Modelo from Marca_Modelo where Marca = @Marca and Modelo = @Modelo ", sqlParams);

            }
        }
        
    }
}



