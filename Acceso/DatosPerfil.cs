﻿using Acceso;
using Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class DatosPerfil : AccesoDatosBase
    {

        #region Constructor
        public DatosPerfil(string cadenaConexion, string nombreBD)
    : base(cadenaConexion, nombreBD)
        {

        }
        #endregion

        #region CRUD


        #region CREATE
        public void Crear(Perfil Perfil)
        {
            Crear(nameof(Perfil), Perfil);
        }
        #endregion

        #region READ
        public List<Perfil> Leer()
        {
            return Leer<Perfil>(nameof(Perfil));
        }
        #endregion

        #region UPDATE
        public void Actualizar(Perfil Perfil)
        {
            var filter = Builders<Perfil>.Filter.Eq(x => x.Codigo, Perfil.Codigo);
            Actualizar<Perfil>(nameof(Perfil), filter, Perfil);
        }
        #endregion

        #region DELETE
        public void Eliminar(string Codigo)
        {
            Eliminar<Perfil>(nameof(Perfil), (u) => u.Codigo == Codigo);
        }
        #endregion

        #region SEARCH
        public Perfil Buscar(string Codigo)
        {
            return Buscar<Perfil>(nameof(Perfil), (u) => u.Codigo == Codigo).FirstOrDefault();
        }
        #endregion 


        #endregion

    }
}
