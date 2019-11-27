using System;

namespace PreParcial
{
    public abstract class Mascota
    {
        #region Atributos
        private string _nombre;
        private string _raza;
        #endregion

        #region Propiedades
        public string Nombre {
            get {
                return this._nombre;
            }
        }
        public string Raza
        {
            get {
                return this._raza;
            }
        }
        #endregion

        #region Metodos
        protected virtual string DatosCompletos()
        {
            return (Nombre + " " + Raza);
        }
        protected abstract string Ficha();
        #region Constructores
        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }
        #endregion
        #endregion
    }
}
