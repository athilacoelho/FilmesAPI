﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dto
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 carcateres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ser entre 1 e 600")]
        public int Duracao { get; set; }
    }
}
