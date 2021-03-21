﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios
{
    public interface IRegistroService
    {
        #region CREATE
        void Crear(Registro Registro);
        #endregion

        #region READ
        List<Registro> Leer();
        #endregion

        #region UPDATE
        void Actualizar(Registro Registro);
        #endregion

        #region DELETE
        void Eliminar(string Codigo);
        #endregion

        #region SEARCH
        Registro Buscar(string Codigo);
        #endregion
    }

    public class RegistroService : IRegistroService
    {
        #region Members
        //Establece propiedades para acceso a datos
        private readonly DatosRegistro accesoDatos;
        #endregion

        #region Constructor
        //Inicializa el servicio
        public RegistroService(DatosRegistro accesoDatos)
        {
            this.accesoDatos = accesoDatos;
        }
        #endregion



        #region CREATE
        public void Crear(Registro Registro)
        {
            accesoDatos.Crear(Registro);
        }
        #endregion

        #region READ
        public List<Registro> Leer()
        {
            return accesoDatos.Leer();
        }
        #endregion

        #region UPDATE
        public void Actualizar(Registro Registro)
        {
            accesoDatos.Actualizar(Registro);
        }
        #endregion

        #region DELETE
        public void Eliminar(string Codigo)
        {
            accesoDatos.Eliminar(Codigo);
        }
        #endregion

        #region SEARCH
        public Registro Buscar(string Codigo)
        {
            return accesoDatos.Buscar(Codigo);
        }
        #endregion
    }
}
