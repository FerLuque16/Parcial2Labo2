using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class FuncionalidadSql
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static FuncionalidadSql()
        {
            try
            {
                conexion = new SqlConnection(@"Data Source = .\sqlexpress; Initial Catalog = JardinUtn; Integrated Security = True");
                comando = new SqlCommand();

                comando.Connection = conexion;
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo conectar a la base de datos", ex.InnerException);
            }
        }

        public static bool InsertarDocente(Docente d)
        {
            int retorno = -1;

            bool resultado = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = "Insert into Docentes (Nombre, Apellido, Edad, Sexo, Dni, Direccion, Email) values (@Nombre, @Apellido, @Edad, @Sexo, @Dni, @Direccion, @Email)";

               // comando.Parameters.Add(new SqlParameter("idDocente", d.Id));
                comando.Parameters.Add(new SqlParameter("Nombre", d.Nombre));
                comando.Parameters.Add(new SqlParameter("Apellido", d.Apellido));
                comando.Parameters.Add(new SqlParameter("Edad", d.Edad));
                comando.Parameters.Add(new SqlParameter("Sexo", d.Sexo));
                comando.Parameters.Add(new SqlParameter("Dni", d.Dni));
                comando.Parameters.Add(new SqlParameter("Direccion", d.Direccion));
                comando.Parameters.Add(new SqlParameter("Email", d.Email));

                retorno = comando.ExecuteNonQuery();


                if (retorno != -1)
                    resultado = true;


            }
            catch (Exception ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        public static bool InsertarEvaluacion(Evaluacion e)
        {
            int retorno = -1;

            bool resultado = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = "Insert into Evaluaciones (idAlumno, idDocente, idAula, Nota_1, Nota_2, NotaFinal, Observaciones) values (@idAlumno, @idDocente, @idAula, @Nota_1, @Nota_2, @NotaFinal, @Observaciones)";

                // comando.Parameters.Add(new SqlParameter("idDocente", d.Id));
                //comando.Parameters.Add(new SqlParameter("idEvaluacion", e.IdEvaluacion));
                comando.Parameters.Add(new SqlParameter("idAlumno", e.IdAlumno));
                comando.Parameters.Add(new SqlParameter("idDocente", e.IdDocente));
                comando.Parameters.Add(new SqlParameter("idAula", e.IdAula));
                comando.Parameters.Add(new SqlParameter("Nota_1", e.Nota1));
                comando.Parameters.Add(new SqlParameter("Nota_2", e.Nota2));
                comando.Parameters.Add(new SqlParameter("NotaFinal", e.NotaFinal));
                comando.Parameters.Add(new SqlParameter("Observaciones", e.Observaciones));

                retorno = comando.ExecuteNonQuery();


                if (retorno != -1)
                    resultado = true;


            }
            catch (Exception ex)
            {

                FuncionalidadLog.GuardarLog(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        public static   Queue<Alumno> CargarAlumnos()
        {
            Queue<Alumno> alumnos = new Queue<Alumno>();
            try
            {
                
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandText = "Select * from Alumnos";
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    //MessageBox.Show(dr[0].ToString());
                    //MessageBox.Show(dr[1].ToString());
                    //provincias.Add((decimal)dr[0], dr[1].ToString());
                    alumnos.Enqueue(new Alumno((int)dr[0],dr[1].ToString(),dr[2].ToString(),(int)dr[3],(int)dr[4],dr[5].ToString()));

                }


            }
            catch (Exception ex)
            {
                FuncionalidadLog.GuardarLog(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            

            return alumnos;
        }


        public static List<Aula> CargarAulas()
        {
            List<Aula> aulas = new List<Aula>();
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandText = "Select * from Aulas";
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    //MessageBox.Show(dr[0].ToString());
                    //MessageBox.Show(dr[1].ToString());
                    //provincias.Add((decimal)dr[0], dr[1].ToString());
                    // alumnos.Enqueue(new Alumno((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3], (int)dr[4], dr[5].ToString()));

                    aulas.Add(new Aula((int)dr[0], dr[1].ToString()));


                }


            }
            catch (Exception ex)
            {
                FuncionalidadLog.GuardarLog(ex.Message);
            }
            finally
            {
                conexion.Close();
            }



            return aulas;
        }

    }
}
