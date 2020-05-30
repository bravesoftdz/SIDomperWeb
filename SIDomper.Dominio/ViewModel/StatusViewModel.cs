﻿namespace SIDomper.Dominio.ViewModel
{
    public class StatusViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int Programa { get; set; }
        public bool NotificarCliente { get; set; }
        public bool NotificarSupervisor { get; set; }
        public bool NotificarConsultor { get; set; }
        public bool NotificarRevenda { get; set; }
        public string Conceito { get; set; }
    }

    public class StatusConsultaViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Programa { get; set; }
        public string NomePrograma
        {
            get
            {
                return RetornarNome();
            }
        }

        private string RetornarNome()
        {
            string Nome = "";
            switch (Programa)
            {
                case 1:
                    Nome = "1-Chamado";
                    break;
                case 2:
                    Nome = "2-Visita";
                    break;
                case 3:
                    Nome = "3-Solicitação";
                    break;
                case 4:
                    Nome = "4-Versão";
                    break;
                case 5:
                    Nome = "5-Qualidade";
                    break;
                case 6:
                    Nome = "6-Base de Conhecimento";
                    break;
                case 7:
                    Nome =  "7-Atividade";
                    break;
                case 8:
                    Nome = "8-Agendamento";
                    break;
                case 10:
                    Nome = "10-Recados";
                    break;
            };
            return Nome;
        }
    }
}
