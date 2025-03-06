using System;
using System.Collections.Generic;
using System.Linq;

public class Forca
{
    public static void Main(string[] args)
    {
        string palavraSecreta(List<string> palavras){
            Random random = new Random();

            int indice = random.Next(palavras.Count);

            string palavraAleatoria = palavras[indice];

            return palavraAleatoria;
        }
        
        string[] verificaPalavra(string palavraAleatoria, List<string> letras, string[] respostas){
            
            for(int i = 0; i<respostas.Length; i++){
                respostas[i] = "_";
            }
            
            for(int i = 0; i<letras.Count; i++){
                for(int j = 0; j<palavraAleatoria.Length; j++){
                    if(letras[i].ToString() == palavraAleatoria[j].ToString()){
                        respostas[j] = letras[i];
                    } 
                }
            }
            
            for(int i=0; i<respostas.Length;i++){
                Console.Write($"{respostas[i]} ");
            }
            Console.Write("\n");
            
            return respostas;
        }

        bool verificaGanhou(string[] respostas){
            if(respostas.Contains("_")){
                return false;
            }else{
                return true;
            }
        }
        
        List<string> palavras = new List<string> {"PROGRAMACAO", "SITE", "DESENVOLVEDOR", "SOFTWARE", "LINGUAGEM"};

        string palavraAleatoria = palavraSecreta(palavras);
        
        string[] respostas = new string[palavraAleatoria.Length];
        
        int contador = 0;
        
        List<string> letras = new List<string> {};
        
        while(contador < 8){
            if(contador == 0){
                respostas = verificaPalavra(palavraAleatoria, letras, respostas);
            }
            
            Console.WriteLine("Digite uma letra: ");
            letras.Add(Console.ReadLine().ToUpper());
                
            respostas = verificaPalavra(palavraAleatoria, letras, respostas);
                
            if(verificaGanhou(respostas)==false){
                contador +=1;
            }else{
                Console.WriteLine("Parabéns! Você acertou a palavra secreta.");
                break;
            }
        }    

        if(contador == 8){
            Console.WriteLine($"Game Over! A palavra secreta era: {palavraAleatoria}");
        }
    }
    
}
