create table tbFuncionarios
(
    ID            int          not null  primary key,
    Nome          varchar(50)   not null,
    Departamento  varchar(5)    not null,
    Salario       int          not null
)
var query = from funcionario in context.tbFuncionarios
            group funcionario by new { funcionario.Departamento, funcionario.Salario } into f
            let salarioTotal = context.tbFuncionarios.Sum(x => x.Salario)
            let mediaSalarial = context.tbFuncionarios.Average(x => x.Salario)
            orderby f.Key.Departamento, f.Key.Salario
            select new
            {
               Salario = f.Key.Salario,
               Departamento = f.Key.Departamento,
               Total = salarioTotal,
               Media = mediaSalarial
            };
foreach (var func in query)
{
    Console.WriteLine("Departamento: " + func.Departamento + "\t" + "Salário: " + func.Salario); //etc..
}


Read more: http://www.linhadecodigo.com.br/artigo/3692/clausulas-let-group-by-e-order-by-no-linq.aspx#ixzz8B9Acsqha

Read more: http://www.linhadecodigo.com.br/artigo/3692/clausulas-let-group-by-e-order-by-no-linq.aspx#ixzz8B9AZVZee

Read more: http://www.linhadecodigo.com.br/artigo/3692/clausulas-let-group-by-e-order-by-no-linq.aspx#ixzz8B9AVmMf4
