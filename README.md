# CrudMVC

#Instruções para Inicializar o projeto 

1-Alterar as configurações do banco de dados no Program.cs
options.UseSqlServer("Server=IDEALPADARTHUR\\SQLEXPRESS;Database=Cliente;Trusted_Connection=True;");
Substituir as configuraçoes de server para seu server e se for necessario adicionar o usuario e senha do banco neste caso foi utilizado o trusted connection mas pode se utilizar a seguinte string de configuração 
Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

2- se for necessario instalar os pacotes nuget :
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.VisualStudio.Web.CodeGeneration.Design

3-Executar os seguintes comandos no console de pacotes nuget para criação do banco de dados 
Add-Migration Criacao-Inicial -Context Contexto
Update-database -Context Contexto

4-Executar o sistema com IIS Express
