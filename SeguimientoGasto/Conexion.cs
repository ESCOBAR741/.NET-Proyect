using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoGasto
{
    internal class Conexion
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        //private DataClasses1DataContext Contexto = new DataClasses1DataContext();

        //**************************************************************
        // Metodos para Usuarios
        public List<Usuarios> listarUsuarios()
        {
            List<Usuarios> list = db.Usuarios.ToList();
            return list;
        }

        public void registrarUsuarios(Usuarios objectousuarioo)
        {
            db.Usuarios.InsertOnSubmit(objectousuarioo);
            db.SubmitChanges();
        }

        public void actualizarUsuarios(Usuarios objectousuarioo)
        {
            Usuarios objusuario = db.Usuarios.Single(r => r.idUsuario == objectousuarioo.idUsuario);
            objusuario.nombres = objectousuarioo.nombres;
            objusuario.apellidos = objectousuarioo.apellidos;
            objusuario.run = objectousuarioo.run;
            objusuario.usuario = objectousuarioo.usuario;
            objusuario.contraseña = objectousuarioo.contraseña;
            //objusuario.fechaContrato = objectousuarioo.fechaContrato;
            objusuario.idDepto = objectousuarioo.idDepto;
            db.SubmitChanges();

        }

        public void eliminarUsuarios(int key)
        {
            Usuarios eliminar = db.Usuarios.Single(r => r.idUsuario == key);
            db.Usuarios.DeleteOnSubmit(eliminar);
            db.SubmitChanges();
        }
        public Usuarios obtenerUsuarios(int key)
        {
            Usuarios lista = db.Usuarios.Single(r => r.idUsuario == key);
            return lista;

        }
        public Usuarios buscarUsuario(string usuario)
        {
            try
            {
                Usuarios lista = db.Usuarios.Single(r => r.usuario == usuario);
                return lista;
            }
            catch (Exception ex)
            {
                // Un usuario vacio, no se encontro el usuario
                Usuarios lista = new Usuarios();
                lista.nombres = "";
                lista.apellidos = "";
                lista.run = "";
                lista.usuario = "";
                lista.contraseña = "";
                lista.idDepto = 0;
                return lista;
            }
            //Usuarios lista = db.Usuarios.Single(r => r.usuario == usuario);
            //Console.Write("ESTO ENTREGA A lista en buscarUsuario: ")
            //Console.WriteLine(db.Usuarios.Single(r => r.usuario == usuario));

        }
        /*
        public List<Usuarios> buscarNombre(string nombre)
        {
            // Realizar la consulta
            var consulta = from c in db.GetTable<Usuarios>()
                           where c.nombres.Contains(nombre)
                           select c;
            List<Usuarios> resultados = consulta.ToList();
            return resultados;
        }*/
        public Usuarios buscarNombre(string nombres)
        {
            try
            {
                Usuarios lista = db.Usuarios.Single(r => r.nombres == nombres);
                return lista;
            }
            catch (Exception ex)
            {
                // Un usuario vacio, no se encontro el usuario
                Usuarios lista = new Usuarios();
                lista.nombres = "";
                lista.apellidos = "";
                lista.run = "";
                lista.usuario = "";
                lista.contraseña = "";
                lista.idDepto = 0;
                return lista;
            }
            //Usuarios lista = db.Usuarios.Single(r => r.usuario == usuario);
            //Console.Write("ESTO ENTREGA A lista en buscarUsuario: ")
            //Console.WriteLine(db.Usuarios.Single(r => r.usuario == usuario));

        }

        //**************************************************************
        // Metodos para Gastos
        public List<Gastos> listarGastos()
        {
            List<Gastos> list = db.Gastos.ToList();
            return list;
        }//listar

        public void registrarGastos(Gastos objectogastoo)
        {
            db.Gastos.InsertOnSubmit(objectogastoo);
            db.SubmitChanges();
        }

        public void actualizarGastos(Gastos objectogastoo)
        {
            Gastos objgasto = db.Gastos.Single(r => r.idGasto == objectogastoo.idGasto);
            objgasto.tipoGasto = objectogastoo.tipoGasto;
            objgasto.detalle = objectogastoo.detalle;
            objgasto.descripcion = objectogastoo.descripcion;
            objgasto.monto = objectogastoo.monto;
            //objgasto.fechaGasto = objectogastoo.fechaGasto;
            objgasto.idUsuario = objectogastoo.idUsuario;
            db.SubmitChanges();

        }

        public void eliminarGastos(int key)
        {
            Gastos eliminar = db.Gastos.Single(r => r.idGasto == key);
            db.Gastos.DeleteOnSubmit(eliminar);
            db.SubmitChanges();
        }
        public Gastos obtenerGastos(int key)
        {
            Gastos lista = db.Gastos.Single(r => r.idGasto == key);
            return lista;

        }

        //****************************************************************
        // Metodos para Departamentos
        public List<Departamentos> listarDepartamentos()
        {
            List<Departamentos> list = db.Departamentos.ToList();
            return list;
        }//listar

        public void registrarDepartamentos(Departamentos objectodeptoo)
        {
            db.Departamentos.InsertOnSubmit(objectodeptoo);
            db.SubmitChanges();
        }

        public void actualizarDepartamentos(Departamentos objectodeptoo)
        {
            Departamentos objdepto = db.Departamentos.Single(r => r.idDepto == objectodeptoo.idDepto);
            objdepto.nombreDepto = objectodeptoo.nombreDepto;
            db.SubmitChanges();

        }

        public void eliminarDepartamentos(int key)
        {
            Departamentos eliminar = db.Departamentos.Single(r => r.idDepto == key);
            db.Departamentos.DeleteOnSubmit(eliminar);
            db.SubmitChanges();
        }
        public Departamentos obtenerDepartamentos(int key)
        {
            Departamentos lista = db.Departamentos.Single(r => r.idDepto == key);
            return lista;

        }
    }
}
