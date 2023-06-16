﻿using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.ModuloFest
{
    public class Festa : EntidadeBase
    {
        public int id;
        public string endereco;
        public DateTime dataCriacao;
        public string horaInicial;
        public string horaFinal;
        public Cliente cliente;

        public Festa(string endereco, DateTime dataCriacao, string horaInicial, string horaFinal, Cliente cliente)
        {
            this.endereco = endereco;
            this.dataCriacao = dataCriacao;
            this.horaInicial = horaInicial;
            this.horaFinal = horaFinal;
            this.cliente = cliente;
        }

        public override string[] Validar()
        {

            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(endereco))
                erros.Add("O campo 'endereco' é obrigatório");

            else if (string.IsNullOrEmpty(horaInicial))
                erros.Add("O campo 'hora inicial' é obrigatório");

            else if (string.IsNullOrEmpty(horaFinal))
                erros.Add("O campo 'hora final' é obrigatório");

            return erros.ToArray();
        }
    }
}
