
---///////////////////////////////////////////////////////////////////////////////////////////////////////

Insert into MATERIA (SIGLA, NOMBRE) Values ('ADM-201', 'FINANZAS I');
Insert into MATERIA (SIGLA, NOMBRE) Values ('ADM-301', 'MONEDA Y BANCA');
Insert into MATERIA (SIGLA, NOMBRE) Values ('COM-890', 'COMUNICACION Y EDUCACION');
Insert into MATERIA (SIGLA, NOMBRE) Values ('COM-801', 'TALLER DE FOTOGRAFIA');
Insert into MATERIA (SIGLA, NOMBRE) Values ('MAT-487', 'INVESTIGACION OPERATIVA III');
Insert into MATERIA (SIGLA, NOMBRE) Values ('INF-669', 'SISTEMAS OPERATIVOS II');
Insert into MATERIA (SIGLA, NOMBRE) Values ('INF-225', 'SISTEMAS DIGITALES');
Insert into MATERIA (SIGLA, NOMBRE) Values ('INF-289', 'TALLER DE PROGRAMACION I');
Insert into MATERIA (SIGLA, NOMBRE) Values ('QUI-201', 'QUIMICA ANALITICA');
Insert into MATERIA (SIGLA, NOMBRE) Values ('MAT-200', 'INTRODUCCION A LA ESTADISTICA');


Select * From MATERIA


---///////////////////////////////////////////////////////////////////////////////////////////////////////

SET IDENTITY_INSERT ESTUDIANTE ON

Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (2612617, 'SALOMON MAURICIO', 'MICHEL', '9372628', convert(datetime,'13-10-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (2622628, 'JHOSELIN', 'MEJIA', '8660423', convert(datetime,'4-8-2001' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (2631035, 'GLORIA FABIANA', 'CACERES', '6499051', convert(datetime,'20-9-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (2641034, 'ALEXIA PAOLA', 'CABRERA', '7372855', convert(datetime,'8-3-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (2652625, 'JOSE IGNACIO', 'ZORRILLA', '8822159', convert(datetime,'8-6-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (1031054, 'KEYLI ALLISON', 'CHOQUE', '12490363', convert(datetime,'14-1-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (1042627, 'MARIA ISABEL', 'ROJAS', '3652401', convert(datetime,'24-8-1979' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (1052626, 'KEVIN WILLIAN', 'TORRICO', '6469592', convert(datetime,'28-1-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (1062621, 'JULIO MAURICIO', 'YAPUR', '12781898', convert(datetime,'14-5-2000' ,103));
Insert into ESTUDIANTE (ID, NOMBRE, APELLIDOS, CI, FECHA_NACIMIENTO) Values (1071050, 'CARLA ALEJANDRA', 'TERRAZAS', '6436509', convert(datetime,'27-6-1988' ,103));

SET IDENTITY_INSERT ESTUDIANTE OFF

Select * From ESTUDIANTE

---///////////////////////////////////////////////////////////////////////////////////////////////////////