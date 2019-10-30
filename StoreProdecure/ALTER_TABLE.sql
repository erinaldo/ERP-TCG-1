alter table sgd.turno add FechaModifica DATETIME
alter table sgd.turno add UsuarioModifica CHAR(12)
alter table sgd.turno add FechaInicio DATETIME
alter table sgd.turno add FechaSalida DATETIME
alter table sgd.turno add IdEmpresaSis CHAR(12)
alter table sgd.turno add IdSucursal CHAR(12)

alter table sgd.Turno_Usuario add FechaModifica DATETIME
alter table sgd.Turno_Usuario add UsuarioModifica CHAR(12)
alter table sgd.Turno_Usuario add IdEmpresaSis CHAR(12)
alter table sgd.Turno_Usuario add IdSucursal CHAR(12)