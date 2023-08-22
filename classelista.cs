static void Main(string[] args)
{
    //Declaração da lista
    List<string> lista = new List<string>();
             
    string opcao = "1";
 
    while(opcao == "1")
    {
        Console.WriteLine("Digite um nome para inserir na lista:");
        string nome = Console.ReadLine();
        //Adiciona o item à lista
        lista.Add(nome);
        Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
        opcao = Console.ReadLine();
    }
    //Ordena a lista
    lista.Sort();
    Console.WriteLine("A lista tem " + lista.Count + " itens:");
    //Imprime cada item da lista
    lista.ForEach(i => Console.WriteLine(i));
}


Read more: http://www.linhadecodigo.com.br/artigo/3676/listt-trabalhando-com-listas-genericas-em-csharp.aspx#ixzz8B9CMPpfQ
