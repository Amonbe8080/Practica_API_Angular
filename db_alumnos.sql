-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 24-12-2019 a las 23:27:52
-- Versión del servidor: 5.7.26
-- Versión de PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_alumnos`
--
CREATE DATABASE IF NOT EXISTS `db_alumnos` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `db_alumnos`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_alumnos`
--

DROP TABLE IF EXISTS `tbl_alumnos`;
CREATE TABLE IF NOT EXISTS `tbl_alumnos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `edad` int(11) NOT NULL,
  `genero` varchar(1) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  `estado` varchar(30) NOT NULL DEFAULT 'Activo',
  `codigo_carrera` int(11) NOT NULL,
  `codigo_centro` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tbl_alumnos_tbl_carreras_idx` (`codigo_carrera`),
  KEY `fk_tbl_alumnos_tbl_centros_estudio1_idx` (`codigo_centro`)
) ENGINE=InnoDB AUTO_INCREMENT=1448669527 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_alumnos`
--

INSERT INTO `tbl_alumnos` (`id`, `nombre`, `apellido`, `edad`, `genero`, `fecha_ingreso`, `estado`, `codigo_carrera`, `codigo_centro`) VALUES
(145777796, 'Maria', 'Jimenez Sossa', 50, 'F', '2022-03-19', 'Activo', 21, 32),
(424424547, 'Juan', 'Ramiro Suarez', 25, 'M', '2022-03-19', 'Activo', 21, 32),
(552144147, 'Maria Carmen', 'Perez Gonzalez', 42, 'F', '2022-03-19', 'Suspendido', 21, 32),
(1007222463, 'Sebastian', 'Alvarez Perez', 32, 'M', '2019-02-23', 'Activo', 22, 32),
(1007222464, 'Antonio', 'Garcia Ruiz', 41, 'M', '2022-03-19', 'Activo', 21, 32),
(1007222466, 'Jhon', 'Jairo Hernandez', 32, 'M', '2022-05-23', 'Activo', 21, 32),
(1007222470, 'Jose Luis', 'Serrano Hernandez', 32, 'M', '2019-02-23', 'Activo', 21, 32),
(1424242874, 'Emiliano', 'Gallardo Arce', 18, 'M', '2022-03-19', 'Activo', 21, 32),
(1448669526, 'Javier', 'Navarro Ospina', 99, 'M', '2019-03-19', 'Suspendido', 21, 32);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_carreras`
--

DROP TABLE IF EXISTS `tbl_carreras`;
CREATE TABLE IF NOT EXISTS `tbl_carreras` (
  `codigo_carrera` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_carrera` varchar(100) DEFAULT NULL,
  `cantidad_asignaturas` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigo_carrera`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_carreras`
--

INSERT INTO `tbl_carreras` (`codigo_carrera`, `nombre_carrera`, `cantidad_asignaturas`) VALUES
(21, 'Adsi', 7),
(22, 'Mantenimiento Electronico', 5),
(23, 'asd', 32),
(24, 'asdwe', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_centros_estudio`
--

DROP TABLE IF EXISTS `tbl_centros_estudio`;
CREATE TABLE IF NOT EXISTS `tbl_centros_estudio` (
  `codigo_centro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_centro_estudio` varchar(100) NOT NULL,
  PRIMARY KEY (`codigo_centro`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_centros_estudio`
--

INSERT INTO `tbl_centros_estudio` (`codigo_centro`, `nombre_centro_estudio`) VALUES
(32, 'Balberit');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_alumnos`
--
ALTER TABLE `tbl_alumnos`
  ADD CONSTRAINT `fk_tbl_alumnos_tbl_carreras` FOREIGN KEY (`codigo_carrera`) REFERENCES `tbl_carreras` (`codigo_carrera`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_alumnos_tbl_centros_estudio1` FOREIGN KEY (`codigo_centro`) REFERENCES `tbl_centros_estudio` (`codigo_centro`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
