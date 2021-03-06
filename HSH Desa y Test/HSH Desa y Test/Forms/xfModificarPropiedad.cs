﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfModificarPropiedad : DevExpress.XtraEditors.XtraForm
    {
        Propiedad propiedadAModificar = null;
        private List<byte[]> fotos = null;

        public xfModificarPropiedad()
        {
            InitializeComponent();
        }

        public xfModificarPropiedad(int idPropiedad)
        {
            InitializeComponent();
            cargarPropiedadAModificar(idPropiedad);
        }

        public void cargarPropiedadAModificar(int idPropiedad)
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
                propiedadAModificar = conexion.Propiedads.Where(p => p.id == idPropiedad).First();

                nombreBox.Text = propiedadAModificar.nombre;
                ubicacionBox.Text = propiedadAModificar.ubicaciòn;
                ciudadBox.Text = propiedadAModificar.ciudad;
                ubicacionBox.Text = propiedadAModificar.ubicaciòn;
                provinciaBox.Text = propiedadAModificar.provincia;
                paisBox.Text =  propiedadAModificar.pais;
                tipoBox.Text = propiedadAModificar.tipo;
                cantHabitaciones.Value = propiedadAModificar.habitaciones;
                boxMonto.Text = propiedadAModificar.montoReserva.ToString();
                label3.Visible = false;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea modificar los datos de la propiedad?", "Cambio de Datos de Propiedad", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                propiedadAModificar.nombre = nombreBox.Text;
                propiedadAModificar.ubicaciòn = ubicacionBox.Text;
                propiedadAModificar.ciudad = ciudadBox.Text;
                propiedadAModificar.provincia = provinciaBox.Text;
                propiedadAModificar.pais = paisBox.Text;
                propiedadAModificar.tipo = tipoBox.Text;
                propiedadAModificar.montoReserva = decimal.Parse(boxMonto.Text);
                propiedadAModificar.habitaciones = decimal.ToInt32(cantHabitaciones.Value);

                using (ContextoEntity conexion = new ContextoEntity())
                {
                    var aux = conexion.Propiedads.Where(p => p.id != propiedadAModificar.id).ToList();

                    if(mismaDir(aux,propiedadAModificar))
                    {
                        MessageBox.Show("La propiedad no puede tener una direccion completa (ubicacion + ciudad + provincia + pais) identica a una ya agregada.");
                        return;
                    }
                    if (propiedadAModificar.nombre == "" || propiedadAModificar.ubicaciòn == "" || propiedadAModificar.ciudad == "" ||
                        propiedadAModificar.provincia == "" || propiedadAModificar.pais == "" || propiedadAModificar.tipo == "") {

                        MessageBox.Show("Ningun campo puede estar vacio.");
                        return;
                    }
                    if (fotos != null)
                    {
                        label3.Visible = true;
                        foreach (byte[] b in fotos)
                        {
                            foto ima = new foto(propiedadAModificar.id, b);
                            conexion.fotos.Add(ima);
                        }
                    }
                    fotos = null;
                    conexion.Entry(propiedadAModificar).State = System.Data.Entity.EntityState.Modified;
                    conexion.SaveChanges();
                    Sesion.vistaPrincipalDeAdmin.vuelveDeModificarPropiedad();
                    this.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarFotoButton_Click(object sender, EventArgs e)
        {
            using (xfAgregarImagenes agregarImagenes = new xfAgregarImagenes())
            {
                agregarImagenes.ShowDialog();
                fotos = agregarImagenes.GetMyResult();
            }
            if (fotos != null) label3.Visible = true;             
        }

        private bool mismaDir(List<Propiedad> listaPropiedades, Propiedad p2)
        {
            bool misma = false;
            Propiedad aux;
            for (int i = 0; i < listaPropiedades.Count; i++)
            {
                aux = listaPropiedades.ElementAt(i);
                  if (aux.ubicaciòn == p2.ubicaciòn)
                    if (aux.ciudad == p2.ciudad)
                      if (aux.provincia == p2.provincia)
                        if (aux.pais == p2.pais)
                            misma = true;
                if (misma) break;
            }
            return misma;
        }

        private void eliminarFotoButton_Click_1(object sender, EventArgs e)
        {
            xfEliminarFoto el = new xfEliminarFoto();
            el.inicializar(propiedadAModificar.id);
        }
    }
}