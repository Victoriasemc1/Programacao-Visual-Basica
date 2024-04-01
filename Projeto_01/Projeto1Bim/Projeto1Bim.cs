using System;

class Program
{
    static void Main(string[] args)
    {
        int cont = 0, primario=0, segundo=0, superior=0, mais25=0, menos25=0, diferencaIdade = 0, salario500 = 0, totalIdade = 0, cont2grau = 0, media = 0, idadeMaior=0, idadeMenor =0,instrucaoMaior=0, instrucaoMenor=0;
        float menorSal = 0, maiorSal = 0, totalSalario = 0, conversao =0;
        double aumento=0,percPrim=0 , percSup = 0 ;
        string nomeMenor= "",nomeMaior="", porcentagem = "";
        
        while (true){
            
            cont++;
            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.Write("Salario:");
            float salario = float.Parse(Console.ReadLine());

            Console.Write("Idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Dolar:");
            float dolar = float.Parse(Console.ReadLine());

            Console.WriteLine("Grau de instrução:\n(1) - primário, (2) - Segundo Grau e (3) - Superior");
            int instrucao = int.Parse(Console.ReadLine());
            
            switch(instrucao){
                case 1 :
                    primario++;
                    break;
                case 2 :
                    segundo++;
                    break;
                case 3 :
                    superior++;
                    break;
            }
            
            //a) 
            if(instrucao == 3 && salario >= 500){
                salario500++;
            }
            
            //b) 
            if(idade <25){
                menos25++;
            }else{
                mais25++;
            }
            diferencaIdade = Math.Abs(mais25 - menos25);
            
            //c)
            if(instrucao == 2){
                cont2grau++;
                totalIdade += idade;
                media = totalIdade/cont2grau;
            }
            
            //d)
            percPrim = ((double)primario/cont)*100;
            percSup = ((double)superior/cont)*100;
            
            //e)
            
            if(salario > maiorSal){
                nomeMaior = nome;
                idadeMaior = idade;
                instrucaoMaior = instrucao;
                maiorSal = salario;
            }
            if(salario < menorSal || menorSal == 0){
                nomeMenor = nome;
                idadeMenor = idade;
                instrucaoMenor = instrucao;
                menorSal = salario;
            }
            
            //f)
            totalSalario += salario;
            
            if(totalSalario > 45000){
                porcentagem = "5%";
                aumento = totalSalario + (totalSalario * 0.05);
            }else if(totalSalario > 35000){
                porcentagem = "10%";
                aumento = totalSalario + (totalSalario * 0.1);
            }
            else if(totalSalario > 20000){
                porcentagem = "20%";
                aumento = totalSalario + (totalSalario * 0.2);
            }else{
                porcentagem = "3%";
                aumento = totalSalario + (totalSalario * 0.03);
            }
            
            //g)
            conversao = totalSalario *dolar;
            
            Console.Write("\nDeseja adicionar mais uma pessoa(S/N):");
            string resp = Console.ReadLine();
            
            
            
            if (resp.ToLower() != "s")
            {
                Console.Write("Resultados:\n");
                Console.Write("\nPessoas cursando superior que ganham mais de 500:"+salario500);
                Console.Write("\nDiferença entre pessoas maiores e menores de 25 anos:"+diferencaIdade);
                Console.Write("\nMedia de idades entre alunos do 2° Grau:"+media);
                Console.Write("\nO percentual de pessoas no primario:"+percPrim+"\nO percentual de pessoas no superior:"+percSup);
                Console.Write("\nPessoa com maior salario:"+nomeMaior+"\nIdade:"+idadeMaior+"\nIntrução:"+instrucaoMaior+"\nSalario:"+maiorSal);
                Console.Write("\nPessoa com menor salario: "+nomeMenor+"\nIdade:"+idadeMenor+"\nIntrução:"+instrucaoMenor+"\nSalario:"+menorSal);
                Console.Write("\nO aumento foi de "+ porcentagem+" e os salarios com acressimos foi de "+aumento);
                Console.Write("\nO somatorio dos salarios em dolar corresponde a:"+conversao);
                break;
            }
        }
    }
}