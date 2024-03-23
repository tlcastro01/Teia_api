using System.ComponentModel.Design;
using Microsoft.Net.Http.Headers;

namespace Teia_api;

public class Palavra
{
    public string texto {get; set;}

    public Palavra(string texto){
       this.texto = texto;
    }

    public bool Palindromo()
    {
        string reversa = new string(this.texto.ToCharArray().Reverse().ToArray());
        return string.Equals(this.texto.ToLower(), reversa.ToLower());
    }

    public Dictionary<char, int> Contar_letras()
    {
        var contagem_de_letras = new Dictionary <char, int>();
        foreach(var caracter in this.texto.ToLower())
        {
            if (contagem_de_letras.ContainsKey(caracter))
            {
                contagem_de_letras[caracter]++;
            }
            else
            {
                contagem_de_letras[caracter] = 1;
            }
        }

        return contagem_de_letras;
    }

}

public class Palavra_atributos
{
    public bool palindromo {get; set;}
    public Dictionary<char, int> ocorrencias_caracteres {set; get;}
    //public var ocorrencias_caracteres => new System.Collections.Generic.Dictionary<string, int>;

    public Palavra_atributos(Palavra texto){
        this.palindromo = texto.Palindromo();
        this.ocorrencias_caracteres = texto.Contar_letras();
    }
}