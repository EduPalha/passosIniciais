﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula2010
{
    class Arquivo
    {
        string nome, mensagem;
        StreamWriter sw;
        StreamReader sr;
        public Arquivo(string nome)
        {
            this.nome = nome;
        }

        public void criaAbreArquivo()
        {
            sw = new StreamWriter("C:\\Arquivos\\" + nome + ".txt", true, Encoding.UTF8);

        }

        public void lerArquivo()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivos\\" + nome + ".txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void gravaMensagem(string mensagem)
        {
            sw.WriteLine(mensagem);
            sw.Flush();
        }

        public void fechaArquivo()
        {
            sw.Close();
        }

    }
}
