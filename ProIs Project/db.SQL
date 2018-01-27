/*
Created: 8/1/2018
Modified: 11/1/2018
Model: Microsoft SQL Server 2014
Database: MS SQL Server 2014
*/


-- Create tables section -------------------------------------------------

-- Table Persona

CREATE TABLE [Persona]
(
 [id_person] Bigint IDENTITY NOT NULL,
 [dni] Varchar(13) NULL,
 [nombre] Varchar(100) NULL,
 [apellido] Varchar(100) NULL,
 [email] Varchar(150) NULL,
 [telefono] Varchar(100) NULL,
 [edad] Int DEFAULT 0 NULL,
 [peso] Decimal(12,2) NULL,
 [altura] Decimal(12,2) NULL,
 [sangre] Varchar(10) NULL,
 [fnac] Date NULL,
 [ecivil] Varchar(100) DEFAULT 'Soltero' NULL,
 [direccion] Varchar(255) NULL,
 [tipo] Int DEFAULT 3 NOT NULL
)
go

-- Add keys for table Persona

ALTER TABLE [Persona] ADD CONSTRAINT [key1] PRIMARY KEY ([id_person])
go

-- Table Medico

CREATE TABLE [Medico]
(
 [id_medico] Int IDENTITY NOT NULL,
 [id_person] Bigint NULL,
 [id_especialidad] Int NULL,
 [titulo] Varchar(100) NULL,
 [h_entrada] Time NULL,
 [h_salida] Time NULL
)
go

-- Create indexes for table Medico

CREATE INDEX [ix_relationship1] ON [Medico] ([id_person])
go

CREATE INDEX [ix_relationship4] ON [Medico] ([id_especialidad])
go

-- Add keys for table Medico

ALTER TABLE [Medico] ADD CONSTRAINT [key2] PRIMARY KEY ([id_medico])
go

-- Table Usuario

CREATE TABLE [Usuario]
(
 [id_usuario] Bigint IDENTITY NOT NULL,
 [password] Varchar(100) NOT NULL,
 [status] Int DEFAULT 0 NULL,
 [id_person] Bigint NULL
)
go

-- Create indexes for table Usuario

CREATE INDEX [ix_relationship2] ON [Usuario] ([id_person])
go

-- Add keys for table Usuario

ALTER TABLE [Usuario] ADD CONSTRAINT [key3] PRIMARY KEY ([id_usuario])
go

-- Table Log

CREATE TABLE [Log]
(
 [id_log] Bigint IDENTITY NOT NULL,
 [nivel] Int DEFAULT 0 NULL,
 [descripcion] Text NULL,
 [status] Int DEFAULT 1 NULL,
 [fecha] Datetime NULL,
 [id_usuario] Bigint NULL
)
go

-- Create indexes for table Log

CREATE INDEX [ix_relationship3] ON [Log] ([id_usuario])
go

-- Add keys for table Log

ALTER TABLE [Log] ADD CONSTRAINT [key4] PRIMARY KEY ([id_log])
go

-- Table Cita

CREATE TABLE [Cita]
(
 [id_medico] Int NULL,
 [id_especialidad] Int NULL,
 [fecha] Datetime NULL,
 [costo] Decimal(18,3) NULL
)
go

-- Create indexes for table Cita

CREATE INDEX [ix_relationship5] ON [Cita] ([id_medico])
go

CREATE INDEX [ix_relationship7] ON [Cita] ([id_especialidad])
go

-- Table Especialidad

CREATE TABLE [Especialidad]
(
 [id_especialidad] Int IDENTITY NOT NULL,
 [nombre] Varchar(100) NULL,
 [descripcion] Varchar(255) NULL
)
go

-- Add keys for table Especialidad

ALTER TABLE [Especialidad] ADD CONSTRAINT [key6] PRIMARY KEY ([id_especialidad])
go

-- Create relationships section ------------------------------------------------- 

ALTER TABLE [Medico] ADD CONSTRAINT [persona_medico] FOREIGN KEY ([id_person]) REFERENCES [Persona] ([id_person]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Usuario] ADD CONSTRAINT [persona_usuario] FOREIGN KEY ([id_person]) REFERENCES [Persona] ([id_person]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Log] ADD CONSTRAINT [usuario_log] FOREIGN KEY ([id_usuario]) REFERENCES [Usuario] ([id_usuario]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Medico] ADD CONSTRAINT [especialidad_medico] FOREIGN KEY ([id_especialidad]) REFERENCES [Especialidad] ([id_especialidad]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Cita] ADD CONSTRAINT [medico_cita] FOREIGN KEY ([id_medico]) REFERENCES [Medico] ([id_medico]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Cita] ADD CONSTRAINT [especialidad_cita] FOREIGN KEY ([id_especialidad]) REFERENCES [Especialidad] ([id_especialidad]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



