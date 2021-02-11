
---///////////////////////////////////////////////////////////////////////////////////////////////////////

DROP TABLE MATERIA; 

CREATE TABLE MATERIA
(
  ID_MATERIA  INT IDENTITY(1,1),
  SIGLA       VARCHAR(7),
  NOMBRE      VARCHAR(100)
);

---///////////////////////////////////////////////////////////////////////////////////////////////////////

DROP TABLE ESTUDIANTE; 

CREATE TABLE ESTUDIANTE
(
  ID                INT IDENTITY(1,1),
  NOMBRE            VARCHAR(30),
  APELLIDOS         VARCHAR(50),
  CI                VARCHAR(12),
  FECHA_NACIMIENTO  DATETIME
);

---///////////////////////////////////////////////////////////////////////////////////////////////////////

DROP TABLE INSCRIPCION; 

CREATE TABLE INSCRIPCION
(
  ID_INSCRIPCION  INT IDENTITY(1,1),
  ID_MATERIA      INT NOT NULL,
  ID_ESTUDIANTE   INT NOT NULL,
  DESCRIPCION     VARCHAR(250) NOT NULL,
  MONTO           DECIMAL(8,2),
  FECHA           DATE
);

Select * From INSCRIPCION

---///////////////////////////////////////////////////////////////////////////////////////////////////////