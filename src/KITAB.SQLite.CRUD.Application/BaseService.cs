﻿using KITAB.SQLite.CRUD.Application.Notificadores;
using KITAB.SQLite.CRUD.Domain.Models;
using FluentValidation;
using FluentValidation.Results;

namespace KITAB.SQLite.CRUD.Application
{
    public abstract class BaseService
    {
        private readonly INotificadorService _notificadorService;

        protected BaseService(INotificadorService notificadorService)
        {
            _notificadorService = notificadorService;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            // Propaga o erro até a camada de apresentação
            _notificadorService.Handle(new Notificacao(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : class
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
