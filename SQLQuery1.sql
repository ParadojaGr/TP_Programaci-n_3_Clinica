USE master;
GO

-- Poner la base de datos en modo de usuario único
ALTER DATABASE ClinicaDB
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;
GO

-- Intentar eliminar la base de datos nuevamente
DROP DATABASE ClinicaDB;
GO

-- Crear la base de datos ClinicaDB
CREATE DATABASE ClinicaDB;
GO

USE [ClinicaDB];
GO

-- Crear la tabla Usuarios
CREATE TABLE [dbo].[Usuarios](
    DNI_USU varchar(8) NOT NULL PRIMARY KEY,
    Usuario_USU varchar(30) NOT NULL,
    Contraseña_USU varchar(30) NOT NULL,
    ES_ADMIN bit NOT NULL DEFAULT 0
);
GO

-- Crear la tabla Provincias
CREATE TABLE [dbo].[Provincias](
    IDProvincia_PRO int NOT NULL PRIMARY KEY,
    Nombre_PRO varchar(30) NOT NULL
);
GO

-- Crear la tabla Localidades
CREATE TABLE [dbo].[Localidades](
    IDLocalidad_LOC int NOT NULL PRIMARY KEY,
    IDProvincia_LOC int NOT NULL,
    Nombre_LOC varchar(30) NOT NULL,
    CONSTRAINT FK_Localidades_Provincias FOREIGN KEY (IDProvincia_LOC) REFERENCES [dbo].[Provincias] (IDProvincia_PRO)
);
GO

-- Crear la tabla ADMIN
CREATE TABLE [dbo].[ADMIN](
    DNI_ADM varchar(8) NOT NULL PRIMARY KEY,
    Apellido_ADM varchar(30) NOT NULL,
    Nombre_ADM varchar(30) NOT NULL,
    CONSTRAINT FK_ADMIN_Usuarios FOREIGN KEY (DNI_ADM) REFERENCES [dbo].[Usuarios] (DNI_USU)
);
GO

-- Crear la tabla Especialidades
CREATE TABLE [dbo].[Especialidades](
    IDEspecialidad_ESP int NOT NULL PRIMARY KEY,
    Nombre_Especialidad_ESP varchar(30) NOT NULL
);
GO

-- Crear la tabla Medicos
CREATE TABLE [dbo].[Medicos](
    Legajo_MED int NOT NULL PRIMARY KEY,
    Nombre_MED varchar(30) NOT NULL,
    DNI_MED varchar(8) NOT NULL,
    Apellido_MED varchar(30) NOT NULL,
    Sexo_MED varchar(1) NOT NULL,
    Nacionalidad_MED varchar(30) NOT NULL,
    FechaNacimiento_MED varchar(30) NOT NULL,
    Direccion_MED varchar(30) NOT NULL,
    Especialidad_MED int NULL,
    Provincia_MED int NULL,
    Localidad_MED int NULL,
    Dia_MED varchar(30) NULL,
    HorarioEntrada_MED varchar(30) NULL,
    HorarioSalida_MED varchar(30) NULL,
    Email_MED varchar(30) NULL,
    Telefono_MED varchar(30) NULL,
    Estado_MED bit NULL,
    CONSTRAINT FK_Medicos_Usuarios FOREIGN KEY (DNI_MED) REFERENCES [dbo].[Usuarios] (DNI_USU),
    CONSTRAINT FK_Medicos_Localidades FOREIGN KEY (Localidad_MED) REFERENCES [dbo].[Localidades] (IDLocalidad_LOC),
    CONSTRAINT FK_Medicos_Provincias FOREIGN KEY (Provincia_MED) REFERENCES [dbo].[Provincias] (IDProvincia_PRO)
);
GO

-- Crear la tabla Pacientes
CREATE TABLE [dbo].[Pacientes](
    DNI_PAC varchar(8) NOT NULL PRIMARY KEY,
    Nombre_PAC varchar(30) NOT NULL,
    Apellido_PAC varchar(30) NOT NULL,
    Sexo_PAC varchar(1) NOT NULL,
    Nacionalidad_PAC varchar(30) NOT NULL,
    FechaNacimiento_PAC varchar(30) NOT NULL,
    Direccion_PAC varchar(30) NOT NULL,
    Provincia_PAC int NULL,
    Localidad_PAC int NULL,
    Email_PAC varchar(30) NULL,
    Telefono_PAC varchar(30) NULL,
    Estado_PAC bit NULL,
    CONSTRAINT FK_Pacientes_Localidades FOREIGN KEY (Localidad_PAC) REFERENCES [dbo].[Localidades] (IDLocalidad_LOC),
    CONSTRAINT FK_Pacientes_Provincias FOREIGN KEY (Provincia_PAC) REFERENCES [dbo].[Provincias] (IDProvincia_PRO)
);
GO

CREATE TABLE [dbo].[Dia](
    NumeroDia_DIA INT NOT NULL PRIMARY KEY,
    Nombre_DIA VARCHAR(12) NOT NULL
);
GO

-- Crear la tabla Hora
CREATE TABLE [dbo].[Hora](
    NumeroHora_HOR INT NOT NULL PRIMARY KEY,
    Descripcion_HOR VARCHAR(10) NOT NULL
);
GO

-- Crear la tabla DiaXHora
CREATE TABLE [dbo].[DiaXHora](
    LegajoMedico_DXH INT NOT NULL,
    NumeroDia_DXH INT NOT NULL,
    NumeroHora_DXH INT NOT NULL,
    Estado_DXH BIT NOT NULL,
    CONSTRAINT PK_DiaXHora PRIMARY KEY (LegajoMedico_DXH, NumeroDia_DXH, NumeroHora_DXH),
    CONSTRAINT FK_DiaXHora_Medico FOREIGN KEY (LegajoMedico_DXH) REFERENCES [dbo].[Medicos] (Legajo_MED),
    CONSTRAINT FK_DiaXHora_Dia FOREIGN KEY (NumeroDia_DXH) REFERENCES [dbo].[Dia] (NumeroDia_DIA),
    CONSTRAINT FK_DiaXHora_Hora FOREIGN KEY (NumeroHora_DXH) REFERENCES [dbo].[Hora] (NumeroHora_HOR)
);
GO

-- Crear la tabla Turnos
CREATE TABLE [dbo].[Turnos](
    IDturno_TUR INT NOT NULL PRIMARY KEY,
    DniPaciente_TUR VARCHAR(8) NULL,
    LegajoMedico_DXH INT NOT NULL,
    NumeroDia_DXH INT NOT NULL,
    NumeroHora_DXH INT NOT NULL,
    Estado_TUR BIT NOT NULL,
    Observacion_TUR VARCHAR(30) NOT NULL,
    CONSTRAINT FK_Turnos_Pacientes FOREIGN KEY (DniPaciente_TUR) REFERENCES [dbo].[Pacientes] (DNI_PAC),
    CONSTRAINT FK_Turnos_DiaXHora FOREIGN KEY (LegajoMedico_DXH, NumeroDia_DXH, NumeroHora_DXH) REFERENCES [dbo].[DiaXHora] (LegajoMedico_DXH, NumeroDia_DXH, NumeroHora_DXH)
);
GO

SELECT 
    T.IDturno_TUR, 
    T.DniPaciente_TUR, 
    P.Nombre_PAC, 
    T.LegajoMedico_DXH AS LegajoMedico_TUR, 
    M.Nombre_MED, 
    D.Nombre_DIA AS Dia_TUR, 
    H.Descripcion_HOR AS Hora_TUR, 
    T.Observacion_TUR, 
    E.Nombre_Especialidad_ESP
FROM 
    [dbo].[Turnos] AS T
INNER JOIN 
	Dia AS D ON T.NumeroDia_DXH = D.NumeroDia_DIA
INNER JOIN
	Hora as H on T.NumeroHora_DXH = H.NumeroHora_HOR
INNER JOIN 
    [dbo].[Medicos] AS M ON M.Legajo_MED = T.LegajoMedico_DXH
INNER JOIN 
    [dbo].[Pacientes] AS P ON P.DNI_PAC = T.DniPaciente_TUR
INNER JOIN 
    [dbo].[Especialidades] AS E ON E.IDEspecialidad_ESP = M.Especialidad_MED
WHERE 
    T.Estado_TUR = 1;

CREATE PROCEDURE spAgregarTurnos
    @IdTurno_TUR INT,
    @DniPaciente_TUR VARCHAR(8),
    @LegajoMedico_TUR INT,
    @Dia_TUR INT,
    @Hora_TUR INT,
    @Estado_TUR BIT,
    @Observacion_TUR VARCHAR(30)
AS
BEGIN
    INSERT INTO Turnos (IDturno_TUR, DniPaciente_TUR, LegajoMedico_DXH, NumeroDia_DXH, NumeroHora_DXH, Estado_TUR, Observacion_TUR)
    VALUES (@IdTurno_TUR, @DniPaciente_TUR, @LegajoMedico_TUR, @Dia_TUR, @Hora_TUR, @Estado_TUR, @Observacion_TUR);
END
GO

CREATE PROCEDURE spActualizarTurnos
    @IdTurno_TUR INT,
    @DniPaciente_TUR VARCHAR(8),
    @LegajoMedico_TUR INT,
    @Dia_TUR INT,
    @Hora_TUR INT,
    @Estado_TUR BIT,
    @Observacion_TUR VARCHAR(30)
AS
BEGIN
    UPDATE Turnos
    SET DniPaciente_TUR = @DniPaciente_TUR,
        LegajoMedico_DXH = @LegajoMedico_TUR,
        NumeroDia_DXH = @Dia_TUR,
        NumeroHora_DXH = @Hora_TUR,
        Estado_TUR = @Estado_TUR,
        Observacion_TUR = @Observacion_TUR
    WHERE IDturno_TUR = @IdTurno_TUR;
END
GO


CREATE PROCEDURE spActualizarEstadoDiaXHora
    @IdMedico INT,
    @NumeroDia INT,
    @NumeroHora INT,
    @Estado BIT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE DiaXHora
        SET Estado_DXH = @Estado
        WHERE LegajoMedico_DXH = @IdMedico
          AND NumeroDia_DXH = @NumeroDia
          AND NumeroHora_DXH = @NumeroHora;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END;

-- Insertar registros en la tabla Usuarios
INSERT INTO Usuarios (DNI_USU, Usuario_USU, Contraseña_USU, ES_ADMIN)
VALUES
('12345678', 'usuario1', 'contraseña1', 0),
('23456789', 'usuario2', 'contraseña2', 1);
