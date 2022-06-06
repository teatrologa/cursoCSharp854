namespace OriObj001
{
    class PrincipalProgram
    {
        static void Main (string[] args)
        {

            Animal animal1 = new Animal();
            animal1.nome = "Chica";
            animal1.especie = Especie.Cachorro;
            animal1.raca = "SRD";
            animal1.cor = "Preta";
            animal1.porte = Porte.Pequeno;
            animal1.peso = 8;
            animal1.nascimento = new DateTime(2015, 12, 1);
            animal1.agressivo = false;
            animal1.sexo = 'F';
            animal1.castrado = true;
            Guid codigoAmimal1 = animal1.ObterCodigo();

            Console.WriteLine(codigoAmimal1);
            Console.WriteLine(animal1.nome);
            Console.WriteLine(animal1.especie);
            Console.WriteLine(animal1.raca);
            Console.WriteLine(animal1.ObterDataCadastro());

        }
    }

}
 