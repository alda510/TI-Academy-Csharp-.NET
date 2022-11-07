while(true){
    Console.Write("Digite a quantidade de notas que serão calculadas: ");

    int quantNotas = Convert.ToInt32(Console.ReadLine());
    double somaNotas = 0;
    char continuar = '.';
    for(int nota = 1; nota <= quantNotas; nota++){
        Console.Write($"Digite a {nota}º nota: ");
        somaNotas += Convert.ToDouble(Console.ReadLine());
    }
    double media = Math.Round (somaNotas/quantNotas, 2);
    Console.WriteLine($"A Média do aluno é: {media}");
    if (media >= 6){
        Console.WriteLine("Está Aprovado! Muito Bom!");
    } else {
        Console.WriteLine("Está reprovado :( Não foi dessa vez champ...");
    }

    do {
        try {
            Console.Write("Deseja escrever a nota para outro aluno? (S/N)");
            continuar = Convert.ToChar(Console.ReadLine().ToLower());
        } catch {
            Console.WriteLine("Digite uma opção válida (S = Sim/ N = Não");
        }
    } while (continuar != 's' && continuar != 'n');

    if (continuar == 'n'){
        Console.WriteLine("Até logo Professor!");
        break;
    }
}