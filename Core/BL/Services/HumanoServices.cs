using Core.BL.Interfaces;
using Microsoft.Data.SqlClient;
using Models.API.Request;
using Models.API.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.BL.Services
{
    public class HumanoServices : IHumano
    {
        #region SELECT ALL e INDIVIDUAL
        public async Task<List<HumanoResponseViewModel>> SELECTHumanoGeneral(int _intAccion, int _intHumanoKey)
        {
            using (var conexion = new SqlConnection(Helpers.ContextConfiguration.ConexionCadena))
            {
                HumanoResponseViewModel responde = new HumanoResponseViewModel();

                var command = new SqlCommand();
                command.Connection = conexion;

                #region PARAMETROS DEL PROCEDIMIENTO ALMACENADO
                var intAccion = command.CreateParameter();
                intAccion.ParameterName = "@intAccion";
                intAccion.Value = _intAccion;
                command.Parameters.Add(intAccion);

                var intHumanoKey = command.CreateParameter();
                intHumanoKey.ParameterName = "@intHumanoKey";
                intHumanoKey.Value = _intHumanoKey;
                command.Parameters.Add(intHumanoKey);

                //var vchBuscador = command.CreateParameter();
                //vchBuscador.ParameterName = "@vchBuscador";
                //vchBuscador.Value = x.vchBuscador;
                //command.Parameters.Add(vchBuscador);

                //var vchNombre = command.CreateParameter();
                //vchNombre.ParameterName = "@vchNombre";
                //vchNombre.Value = x.vchNombre;
                //command.Parameters.Add(vchNombre);

                //var vchPrimerApellido = command.CreateParameter();
                //vchPrimerApellido.ParameterName = "@vchPrimerApellido";
                //vchPrimerApellido.Value = x.vchPrimerApellido;
                //command.Parameters.Add(vchPrimerApellido);

                //var vchSegundoApellido = command.CreateParameter();
                //vchSegundoApellido.ParameterName = "@vchSegundoApellido";
                //vchSegundoApellido.Value = x.vchSegundoApellido;
                //command.Parameters.Add(vchSegundoApellido);

                //var intGeneroLink = command.CreateParameter();
                //intGeneroLink.ParameterName = "@intGeneroLink";
                //intGeneroLink.Value = x.intGeneroLink;
                //command.Parameters.Add(intGeneroLink);

                //var intEdad = command.CreateParameter();
                //intEdad.ParameterName = "@intEdad";
                //intEdad.Value = x.intEdad;
                //command.Parameters.Add(intEdad);

                //var fltAltura = command.CreateParameter();
                //fltAltura.ParameterName = "@fltAltura";
                //fltAltura.Value = x.fltAltura;
                //command.Parameters.Add(fltAltura);

                //var fltPeso = command.CreateParameter();
                //fltPeso.ParameterName = "@fltPeso";
                //fltPeso.Value = x.fltPeso;
                //command.Parameters.Add(fltPeso);

                //var intErrorNumber = command.CreateParameter();
                //intErrorNumber.ParameterName = "@intErrorNumber";
                //intErrorNumber.Value = x.intErrorNumber;
                //command.Parameters.Add(intErrorNumber);

                //var vchErrorMessage = command.CreateParameter();
                //vchErrorMessage.ParameterName = "@vchErrorMessage";
                //vchErrorMessage.Value = x.vchErrorMessage;
                //command.Parameters.Add(vchErrorMessage);
                #endregion
                #region EJECUCION DEL PROCEDIMIENTO ALMACENADO
                command.CommandText = "[dbo].[spSELECTHumanoGeneral]";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                conexion.Open();
                #endregion
                var result = new List<HumanoResponseViewModel>();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            //Creamos el Objeto JSON
                            var item = new HumanoResponseViewModel
                            {
                                intHumanoKey = (int) reader["intHumanoKey"],
                                vchNombre = reader["vchNombre"].ToString(),
                                vchPrimerApellido = reader["vchPrimerApellido"].ToString(),
                                vchSegundoApellido = reader["vchSegundoApellido"].ToString(),
                                vchNombreCompleto = reader["vchNombreCompleto"].ToString(),
                                vchGenero = reader["vchGenero"].ToString(),
                                intEdad = (int)reader["intEdad"],
                                fltAltura = (double)reader["fltAltura"],
                                fltPeso = (double)reader["fltPeso"]
                            };

                            result.Add(item);

                        }
                        catch (Exception ex)
                        {
                            var Valor = ex.Message.ToString();
                        }
                    }

                    conexion.Close();
                    return result;
                }
            }
        }
        #endregion
        #region INSERT
        public async Task<CRUDHumanoResponsetViewModel> CRUDHumanoGeneral(CRUDHumanoRequestViewModel x)
        {
            using (var conexion = new SqlConnection(Helpers.ContextConfiguration.ConexionCadena))
            {
                CRUDHumanoResponsetViewModel responde = new CRUDHumanoResponsetViewModel();

                var command = new SqlCommand();
                command.Connection = conexion;

                #region PARAMETROS DEL PROCEDIMIENTO ALMACENADO
                var intAccion = command.CreateParameter();
                intAccion.ParameterName = "@intAccion";
                intAccion.Value = 2;
                command.Parameters.Add(intAccion);

                var intHumanoKey = command.CreateParameter();
                intHumanoKey.ParameterName = "@intHumanoKey";
                intHumanoKey.Value = 0;
                command.Parameters.Add(intHumanoKey);


                var vchNombre = command.CreateParameter();
                vchNombre.ParameterName = "@vchNombre";
                vchNombre.Value = x.vchNombre;
                command.Parameters.Add(vchNombre);

                var vchPrimerApellido = command.CreateParameter();
                vchPrimerApellido.ParameterName = "@vchPrimerApellido";
                vchPrimerApellido.Value = x.vchPrimerApellido;
                command.Parameters.Add(vchPrimerApellido);

                var vchSegundoApellido = command.CreateParameter();
                vchSegundoApellido.ParameterName = "@vchSegundoApellido";
                vchSegundoApellido.Value = x.vchSegundoApellido;
                command.Parameters.Add(vchSegundoApellido);

                var intGeneroLink = command.CreateParameter();
                intGeneroLink.ParameterName = "@intGeneroLink";
                intGeneroLink.Value = x.intGeneroLink;
                command.Parameters.Add(intGeneroLink);

                var intEdad = command.CreateParameter();
                intEdad.ParameterName = "@intEdad";
                intEdad.Value = x.intEdad;
                command.Parameters.Add(intEdad);

                var fltAltura = command.CreateParameter();
                fltAltura.ParameterName = "@fltAltura";
                fltAltura.Value = x.fltAltura;
                command.Parameters.Add(fltAltura);

                var fltPeso = command.CreateParameter();
                fltPeso.ParameterName = "@fltPeso";
                fltPeso.Value = x.fltPeso;
                command.Parameters.Add(fltPeso);

                var intErrorNumber = command.CreateParameter();
                intErrorNumber.ParameterName = "@intErrorNumber";
                intErrorNumber.Value = x.intErrorNumber;
                command.Parameters.Add(intErrorNumber);

                var vchErrorMessage = command.CreateParameter();
                vchErrorMessage.ParameterName = "@vchErrorMessage";
                vchErrorMessage.Value = x.vchErrorMessage;
                command.Parameters.Add(vchErrorMessage);
                #endregion
                #region EJECUCION DEL PROCEDIMIENTO ALMACENADO
                command.CommandText = "[dbo].[spHumanoGeneral]";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                conexion.Open();
                #endregion

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            responde.Mensaje = reader.GetString(reader.GetOrdinal("Mensaje"));
                        }
                        catch (Exception ex)
                        {
                            var Valor = ex.Message.ToString();
                        }
                    }

                    conexion.Close();
                    return responde;
                }
            }
        }
        #endregion
        #region UPDATE
        public async Task<CRUDHumanoResponsetViewModel> UPDATEHumanoGeneral(int _intAccion, int _intHumanoKey, CRUDHumanoRequestViewModel x)
        {
            using (var conexion = new SqlConnection(Helpers.ContextConfiguration.ConexionCadena))
            {
                CRUDHumanoResponsetViewModel responde = new CRUDHumanoResponsetViewModel();

                var command = new SqlCommand();
                command.Connection = conexion;

                #region PARAMETROS DEL PROCEDIMIENTO ALMACENADO
                var intAccion = command.CreateParameter();
                intAccion.ParameterName = "@intAccion";
                intAccion.Value = _intAccion;
                command.Parameters.Add(intAccion);

                var intHumanoKey = command.CreateParameter();
                intHumanoKey.ParameterName = "@intHumanoKey";
                intHumanoKey.Value = _intHumanoKey;
                command.Parameters.Add(intHumanoKey);


                var vchNombre = command.CreateParameter();
                vchNombre.ParameterName = "@vchNombre";
                vchNombre.Value = x.vchNombre;
                command.Parameters.Add(vchNombre);

                var vchPrimerApellido = command.CreateParameter();
                vchPrimerApellido.ParameterName = "@vchPrimerApellido";
                vchPrimerApellido.Value = x.vchPrimerApellido;
                command.Parameters.Add(vchPrimerApellido);

                var vchSegundoApellido = command.CreateParameter();
                vchSegundoApellido.ParameterName = "@vchSegundoApellido";
                vchSegundoApellido.Value = x.vchSegundoApellido;
                command.Parameters.Add(vchSegundoApellido);

                var intGeneroLink = command.CreateParameter();
                intGeneroLink.ParameterName = "@intGeneroLink";
                intGeneroLink.Value = x.intGeneroLink;
                command.Parameters.Add(intGeneroLink);

                var intEdad = command.CreateParameter();
                intEdad.ParameterName = "@intEdad";
                intEdad.Value = x.intEdad;
                command.Parameters.Add(intEdad);

                var fltAltura = command.CreateParameter();
                fltAltura.ParameterName = "@fltAltura";
                fltAltura.Value = x.fltAltura;
                command.Parameters.Add(fltAltura);

                var fltPeso = command.CreateParameter();
                fltPeso.ParameterName = "@fltPeso";
                fltPeso.Value = x.fltPeso;
                command.Parameters.Add(fltPeso);

                var intErrorNumber = command.CreateParameter();
                intErrorNumber.ParameterName = "@intErrorNumber";
                intErrorNumber.Value = x.intErrorNumber;
                command.Parameters.Add(intErrorNumber);

                var vchErrorMessage = command.CreateParameter();
                vchErrorMessage.ParameterName = "@vchErrorMessage";
                vchErrorMessage.Value = x.vchErrorMessage;
                command.Parameters.Add(vchErrorMessage);
                #endregion
                #region EJECUCION DEL PROCEDIMIENTO ALMACENADO
                command.CommandText = "[dbo].[spHumanoGeneral]";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                conexion.Open();
                #endregion

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            responde.Mensaje = reader.GetString(reader.GetOrdinal("Mensaje"));
                        }
                        catch (Exception ex)
                        {
                            var Valor = ex.Message.ToString();
                        }
                    }

                    conexion.Close();
                    return responde;
                }
            }
        }
        #endregion
    }
}
