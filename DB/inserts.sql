select * from cursos;
select * from maestros;

select * from facultades;
INSERT INTO `siu`.`facultades` (`codigo_facultad`, `nombre_facultad`, `estatus_facultad`) VALUES ('001', 'Ingeniería', 'A');
INSERT INTO `siu`.`facultades` (`codigo_facultad`, `nombre_facultad`, `estatus_facultad`) VALUES ('002', 'Ciencias Médicas', 'A');

select * from carreras;
INSERT INTO `siu`.`carreras` (`codigo_carrera`, `nombre_carrera`, `codigo_facultad`, `estatus_carrera`) VALUES ('1', 'Sistemas', '001', 'A');
INSERT INTO `siu`.`carreras` (`codigo_carrera`, `nombre_carrera`, `codigo_facultad`, `estatus_carrera`) VALUES ('2', 'Medicina', '002', 'A');

select * from sedes;
INSERT INTO `siu`.`sedes` (`codigo_sede`, `nombre_sede`, `estatus_sede`) VALUES ('50', 'Central', 'A');
INSERT INTO `siu`.`sedes` (`codigo_sede`, `nombre_sede`, `estatus_sede`) VALUES ('51', 'Portales', 'A');

select * from jornadas;
INSERT INTO `siu`.`jornadas` (`codigo_jornada`, `nombre_jornada`, `estatus_jornada`) VALUES ('90', 'Matutina', 'A');
INSERT INTO `siu`.`jornadas` (`codigo_jornada`, `nombre_jornada`, `estatus_jornada`) VALUES ('91', 'Vespertina', 'A');
INSERT INTO `siu`.`jornadas` (`codigo_jornada`, `nombre_jornada`, `estatus_jornada`) VALUES ('92', 'Nocturna', 'A');

select * from secciones;
INSERT INTO `siu`.`secciones` (`codigo_seccion`, `nombre_seccion`, `estatus_seccion`) VALUES ('7', 'A', 'A');
INSERT INTO `siu`.`secciones` (`codigo_seccion`, `nombre_seccion`, `estatus_seccion`) VALUES ('8', 'B', 'A');

select * from aulas;
INSERT INTO `siu`.`aulas` (`codigo_aula`, `nombre_aula`, `estatus_aula`) VALUES ('100', 'Aula 1', 'A');
INSERT INTO `siu`.`aulas` (`codigo_aula`, `nombre_aula`, `estatus_aula`) VALUES ('101', 'Aula 2', 'A');

select * from cursos;

select * from asignacioncursosmastros;