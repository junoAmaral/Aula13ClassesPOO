
using Aula13ClassesPOO;

Console.WriteLine("Hello, World!\n");

Pessoa nicolas = new Pessoa("Nícolas", 18, "R. José Fernandes Nunes", "São Carlos");
Pessoa andrey = new Pessoa("Andrey", 12, "R. José Fernandes Nunes", "São Carlos");
Pessoa du = new Pessoa("Eduardo B.", 18, "Av. José Pereira Lopes", "São Carlos");
Pessoa dudu = new Pessoa("Eduardo L.", 18, "Av. Comendador Alfredo Maffei", "São Carlos");

List<Pessoa> pessoas= new List<Pessoa>();
pessoas.Add(nicolas);
pessoas.Add(andrey);
pessoas.Add(du);
pessoas.Add(dudu);

for (int i = 0;i < pessoas.Count; i++)
{
    pessoas[i].mostra();
    //Console.WriteLine(pessoas[i].nome);
}

Console.ReadKey();