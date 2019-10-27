select * from ALM.GrifoCosto
select * from alm.RegistroConsumoCombustible
select * from cmp.ordenventa
select * from std.Material
select * from SGD.Usuario

select * from grf.EstacionServicio

--exec GRF.EstacionServicio_IAE 'I', -1, '', '', 'ESTACION SERVICIO ALEX Y LALITO', 1, 'ADMINERP'
--exec GRF.EstacionServicio_IAE 'A', 1, '', '', 'ESTACION SERVICIO ALEX & LALITO', 1, 'ADMINERP'
--exec GRF.EstacionServicio_IAE 'E', 1, '', '', 'ESTACION SERVICIO ALEX & LALITO', 1, 'ADMINERP'

-- exec GRF.EstacionServicio_LST 'N'

select * from grf.Isla

--exec GRF.Isla_IAE 'I', -1, '', '', 1, 'ISLA 1', 1, 'ADMINERP'
--exec GRF.Isla_IAE 'I', -1, '', '', 1, 'ISLA 2', 1, 'ADMINERP'
--exec GRF.Isla_IAE 'A', 2, '', '', 1, 'ISLA 2', 1, 'ADMINERP'
--exec GRF.Isla_IAE 'E', 2, '', '', 1, 'ISLA 2', 1, 'ADMINERP'

-- exec GRF.Isla_LST 'N'

select * from grf.Lado

--exec GRF.Lado_IAE 'I', -1, '', '', 1, 'LADO 1', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'I', -1, '', '', 1, 'LADO 2', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'I', -1, '', '', 1, 'LADO 3', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'I', -1, '', '', 1, 'LADO 4', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'I', -1, '', '', 2, 'LADO 5', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'I', -1, '', '', 2, 'LADO 6', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'A', 6, '', '', 2, 'LADO 6', 1, 'ADMINERP'
--exec GRF.Lado_IAE 'E', 6, '', '', 2, 'LADO 6', 1, 'ADMINERP'

--exec GRF.Lado_LST 'N'

select * from grf.distribuidor

--exec GRF.Distribuidor_IAE 'I', -1, '', '', 1, '', 'DB5', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 1, '', 'D84', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 1, '', 'D90', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 1, '', 'D95', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 2, '', 'D95', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 2, '', 'D90', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 2, '', 'D85', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'I', -1, '', '', 2, '', 'DB5', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'A', 7, '', '', 2, '', 'D84', 1, 'ADMINERP'
--exec GRF.Distribuidor_IAE 'E', 8, '', '', 2, '', 'DB55', 1, 'ADMINERP'

--exec GRF.Distribuidor_LST 'N'

select * from sgd.turno

--exec [SGD].[Isp_Turno_IAE] 'I', '', '07:00:00.0000000', '19:00:00.0000000', 'Domingo', '1', 'ADMINERP', 1, '1SI', '27/10/2019', '27/10/2019'
--exec [SGD].[Isp_Turno_IAE] 'I', '', '19:00:00.0000000', '07:00:00.0000000', 'Domingo', '2', 'ADMINERP', 1, '1SI', '27/10/2019', '28/10/2019'
--exec [SGD].[Isp_Turno_IAE] 'A', '1SI0003', '07:00:00.0000000', '19:00:00.0000000', 'Lunes', '1', 'ADMINERP', 1, '1SI', '28/10/2019', '28/10/2019'

--exec [SGD].[Isp_Turno_Listar] ''

select * from sgd.Turno_Usuario

--exec [SGD].[Isp_Turno_Usuario_IAE] 'I', '', '1SI0001', '1SI000000000', 'ADMINERP', 1, '1SI'
--exec [SGD].[Isp_Turno_Usuario_IAE] 'I', '', '1SI0002', '1SI000000000', 'ADMINERP', 1, '1SI'

--exec [SGD].[Isp_Turno_Usuario_Listar]

select * from grf.turnocierre

--exec GRF.TurnoCierre_IAE 'I', -1, '', '', '1SI0001', 1, '27/10/2019', '0000000001', 1, 0.82, 0.18, 1.00, '001-00001', '001-00002', 0, 0.0, 3.25, 1, 'ADMINERP'
--exec GRF.TurnoCierre_IAE 'A', 1, '', '', '1SI0001', 1, '27/10/2019', '0000000001', 1, 0.82, 0.18, 1.00, '001-00001', '001-00002', 0, 0.0, 3.25, 1, 'ADMINERP'

--exec GRF.TurnoCierre_LST 'N'

select * from grf.contometro_electronico


--exec GRF.ContoMetroEletronico_IAE 'I', -1, '', '', '1SI0001', 2, 6234.296, 6234.681, 0.385, 0, 0.385, 12.99, 5.00, 1, 'ADMINERP'
--exec GRF.ContoMetroEletronico_IAE 'I', -1, '', '', '1SI0001', 7, 5605.512, 5605.897, 0.385, 0, 0.385, 12.99, 5.00, 1, 'ADMINERP'

--exec GRF.Contometro_Electronico_LST 'N'

select * from grf.contometro_mecanico

--exec GRF.ContoMetroMecanico_IAE 'I', -1, '', '', '1SI0001', 2, 1, 6222, 6223, 1, 0.385, 0.615, 1, 'ADMINERP'
--exec GRF.ContoMetroMecanico_IAE 'I', -1, '', '', '1SI0001', 7, 2, 5596, 5597, 1, 0.385, 0.615, 1, 'ADMINERP'

exec GRF.Contometro_Mecanico_LST 'N'

