DROP DATABASE db_phones;
CREATE DATABASE IF NOT EXISTS db_phones DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE db_phones;

DROP TABLE IF EXISTS t_battery;
CREATE TABLE IF NOT EXISTS t_battery (
  `idBattery` int(11) NOT NULL AUTO_INCREMENT,
  `batCapacity` int(11) NOT NULL,
  `batDuration` int(11) NOT NULL,
  PRIMARY KEY (`idBattery`),
  UNIQUE KEY `ID_t_battery_IND` (`idBattery`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

INSERT INTO t_battery (idBattery, batCapacity, batDuration) VALUES
(1, 800, 3),
(2, 2658, 5),
(3, 2716, 13),
(4, 2942, 16),
(5, 3000, 8),
(6, 3000, 14),
(7, 3046, 7),
(8, 3110, 17),
(9, 3140, 6),
(10, 3200, 22),
(11, 3300, 7),
(12, 3320, 13),
(13, 3330, 7),
(14, 3400, 18),
(15, 3400, 10),
(16, 3500, 4),
(17, 3500, 11),
(18, 3700, 8),
(19, 3800, 11),
(20, 4000, 6),
(21, 4000, 13),
(22, 4000, 20),
(23, 4000, 10),
(24, 4100, 8),
(25, 4200, 8),
(26, 4200, 17),
(27, 4500, 13),
(28, 5000, 21),
(29, 6000, 12);

DROP TABLE IF EXISTS t_cpu;
CREATE TABLE IF NOT EXISTS t_cpu (
  `idCPU` int(11) NOT NULL AUTO_INCREMENT,
  `cpuNbrCore` int(11) NOT NULL,
  `cpuFrequence` float NOT NULL,
  PRIMARY KEY (`idCPU`),
  UNIQUE KEY `ID_t_cpu_IND` (`idCPU`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

INSERT INTO t_cpu (idCPU, cpuNbrCore, cpuFrequence) VALUES
(1, 4, 1.8),
(2, 6, 2.66),
(3, 6, 2.39),
(4, 6, 2.49),
(5, 8, 1.4),
(6, 8, 1.5),
(7, 8, 1.6),
(8, 8, 2),
(9, 8, 2.2),
(10, 8, 2.4),
(11, 8, 2.42),
(12, 8, 2.6),
(13, 8, 2.7),
(14, 8, 2.73),
(15, 8, 2.8),
(16, 8, 2.84),
(17, 8, 2.9),
(18, 8, 2.96),
(19, 8, 3.6);

DROP TABLE IF EXISTS t_manufacturer;
CREATE TABLE IF NOT EXISTS t_manufacturer (
  `idManufacturer` int(11) NOT NULL AUTO_INCREMENT,
  `manName` varchar(50) NOT NULL,
  PRIMARY KEY (`idManufacturer`),
  UNIQUE KEY `ID_t_manufacturer_IND` (`idManufacturer`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

INSERT INTO t_manufacturer (idManufacturer, manName) VALUES
(1, 'Asus'),
(2, 'Google'),
(3, 'Honor'),
(4, 'Huawei'),
(5, 'Apple'),
(6, 'LG'),
(7, 'Motorola'),
(8, 'Nokia'),
(9, 'oneplus'),
(10, 'Oppo'),
(11, 'Palm'),
(12, 'Red digital Cinema'),
(13, 'Samsung'),
(14, 'Sony'),
(15, 'Vivo'),
(16, 'Xiaomi');

DROP TABLE IF EXISTS t_operativesystem;
CREATE TABLE IF NOT EXISTS t_operativesystem (
  `idOperativeSystem` int(11) NOT NULL AUTO_INCREMENT,
  `opeName` varchar(50) NOT NULL,
  PRIMARY KEY (`idOperativeSystem`),
  UNIQUE KEY `ID_t_operativeSystem_IND` (`idOperativeSystem`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

INSERT INTO t_operativesystem (idOperativeSystem, opeName) VALUES
(1, 'Android'),
(2, 'iOS');

DROP TABLE IF EXISTS t_price;
CREATE TABLE IF NOT EXISTS t_price (
  `idPrice` int(11) NOT NULL AUTO_INCREMENT,
  `priPrice` float NOT NULL,
  `priDate` date NOT NULL,
  `fkTelephone` int(11) NOT NULL,
  PRIMARY KEY (`idPrice`),
  UNIQUE KEY `ID_t_price_IND` (`idPrice`),
  KEY `FKcost_IND` (`fkTelephone`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8;

INSERT INTO t_price (idPrice, priPrice, priDate, fkTelephone) VALUES
(1, 949, '2019-09-20', 1),
(2, 629, '2019-11-22', 2),
(3, 889, '2018-10-10', 3),
(4, 1019.9, '2019-10-16', 4),
(5, 569, '2019-01-23', 5),
(6, 964, '2019-09-06', 6),
(7, 999, '2019-03-26', 7),
(8, 808, '2019-09-11', 8),
(9, 1389, '2019-09-11', 9),
(10, 1199, '2017-10-02', 10),
(11, 879, '2018-09-14', 11),
(12, 1249, '2018-09-13', 12),
(13, 241.5, '2019-07-15', 13),
(14, 261.25, '2019-02-13', 14),
(15, 672.1, '2019-02-26', 15),
(16, 649, '2019-10-14', 16),
(17, 492, '2019-11-13', 17),
(18, 446.9, '2019-07-12', 18),
(19, 1264.23, '2018-11-02', 19),
(20, 199.85, '2019-05-06', 20),
(21, 979, '2019-08-08', 21),
(22, 1036, '2018-10-08', 22),
(23, 899, '2019-02-22', 23),
(24, 999, '2019-02-21', 24),
(25, 878.95, '2018-02-26', 25),
(26, 999, '2019-02-26', 26),
(27, 852, '2019-09-07', 27),
(28, 450.23, '2018-05-29', 28),
(29, 692, '2019-03-18', 29),
(30, 536.9, '2019-02-25', 30),
(31, 859.4, '2020-01-29', 1),
(32, 578, '2020-01-29', 2),
(33, 599, '2020-01-29', 3),
(34, 816, '2020-01-29', 4),
(35, 366, '2020-01-29', 5),
(36, 882.9, '2020-01-29', 6),
(37, 699, '2020-01-29', 7),
(38, 809, '2020-01-29', 8),
(39, 1295, '2020-01-29', 9),
(40, 928, '2020-01-29', 10),
(41, 640.85, '2020-01-29', 11),
(42, 649, '2020-01-29', 12),
(43, 172.9, '2020-01-29', 13),
(44, 139, '2020-01-29', 14),
(45, 540, '2020-01-29', 15),
(46, 649, '2020-01-29', 16),
(47, 449, '2020-01-29', 17),
(48, 420.55, '2020-01-29', 18),
(49, 291.9, '2020-01-29', 19),
(50, 149.9, '2020-01-29', 20),
(51, 747, '2020-01-29', 21),
(52, 949.95, '2020-01-29', 22),
(53, 729, '2020-01-29', 23),
(54, 748, '2020-01-29', 24),
(55, 545, '2020-01-29', 25),
(56, 649, '2020-01-29', 26),
(57, 668, '2020-01-29', 27),
(58, 317, '2020-01-29', 28),
(59, 649, '2020-01-29', 29),
(60, 356.15, '2020-01-29', 30);

DROP TABLE IF EXISTS t_ram;
CREATE TABLE IF NOT EXISTS t_ram (
  `idRam` int(11) NOT NULL AUTO_INCREMENT,
  `ramQuantity` int(11) NOT NULL,
  PRIMARY KEY (`idRam`),
  UNIQUE KEY `ID_t_ram_IND` (`idRam`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

INSERT INTO t_ram (idRam, ramQuantity) VALUES
(1, 2),
(2, 3),
(3, 4),
(4, 6),
(5, 8);

DROP TABLE IF EXISTS t_screen;
CREATE TABLE IF NOT EXISTS t_screen (
  `idScreen` int(11) NOT NULL AUTO_INCREMENT,
  `scrSize` float NOT NULL,
  PRIMARY KEY (`idScreen`),
  UNIQUE KEY `ID_t_screen_IND` (`idScreen`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

INSERT INTO t_screen (idScreen, scrSize) VALUES
(1, 3.3),
(2, 5.7),
(3, 5.8),
(4, 5.99),
(5, 6.1),
(6, 6.2),
(7, 6.28),
(8, 6.3),
(9, 6.39),
(10, 6.4),
(11, 6.5),
(12, 6.55),
(13, 6.59),
(14, 7.2);

DROP TABLE IF EXISTS t_storage;
CREATE TABLE IF NOT EXISTS t_storage (
  `idStorage` int(11) NOT NULL AUTO_INCREMENT,
  `stoCapacity` int(11) NOT NULL,
  PRIMARY KEY (`idStorage`),
  UNIQUE KEY `ID_t_storage_IND` (`idStorage`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

INSERT INTO t_storage (idStorage, stoCapacity) VALUES
(1, 32),
(2, 64),
(3, 128),
(4, 256);

DROP TABLE IF EXISTS t_telephone;
CREATE TABLE IF NOT EXISTS t_telephone (
  `idTelephone` int(11) NOT NULL AUTO_INCREMENT,
  `telName` varchar(50) NOT NULL,
  `fkStorage` int(11) NOT NULL,
  `fkCPU` int(11) NOT NULL,
  `fkRam` int(11) NOT NULL,
  `fkManufacturer` int(11) NOT NULL,
  `fkBattery` int(11) NOT NULL,
  `fkOperativeSystem` int(11) NOT NULL,
  `fkVendor` int(11) NOT NULL,
  `fkScreen` int(11) NOT NULL,
  PRIMARY KEY (`idTelephone`),
  UNIQUE KEY `ID_t_telephone_IND` (`idTelephone`),
  KEY `FKutilize_IND` (`fkStorage`),
  KEY `FKuse_IND` (`fkCPU`),
  KEY `FKmakeUseOf_IND` (`fkRam`),
  KEY `FKmake_IND` (`fkManufacturer`),
  KEY `FKhave_IND` (`fkBattery`),
  KEY `FKexploit_IND` (`fkOperativeSystem`),
  KEY `FKdeliver_IND` (`fkVendor`),
  KEY `FKconstitute_IND` (`fkScreen`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

INSERT INTO t_telephone (idTelephone, telName, fkStorage, fkCPU, fkRam, fkManufacturer, fkBattery, fkOperativeSystem, fkVendor, fkScreen) VALUES
(1, 'Asus ROG Phone 2', 3, 18, 5, 1, 29, 1, 1, 14),
(2, 'Asus Zenfone 6', 3, 16, 4, 1, 28, 1, 5, 11),
(3, 'Google Pixel 3', 2, 8, 3, 2, 5, 1, 2, 2),
(4, 'Google Pixel 4 XL', 2, 15, 4, 2, 18, 1, 3, 9),
(5, 'Honor View 20', 3, 10, 4, 3, 20, 1, 4, 11),
(6, 'Huawei Mate 20X', 4, 12, 5, 4, 25, 1, 5, 14),
(7, 'Huawei P30 Pro', 3, 12, 5, 4, 26, 1, 6, 12),
(8, 'iPhone 11', 2, 2, 3, 5, 8, 2, 7, 6),
(9, 'iPhone 11 Pro', 4, 19, 4, 5, 7, 2, 4, 4),
(10, 'iPhone X', 2, 3, 2, 5, 3, 2, 8, 4),
(11, 'iPhone XR', 2, 4, 2, 5, 4, 2, 1, 6),
(12, 'iPhone XS Smartphone', 2, 4, 3, 5, 2, 2, 4, 4),
(13, 'LG Q60', 2, 6, 2, 6, 16, 1, 9, 7),
(14, 'Moto G7', 1, 1, 1, 7, 6, 1, 10, 3),
(15, 'Nokia 9 PureView', 3, 16, 4, 8, 12, 1, 11, 5),
(16, 'OnePlus 7T', 3, 18, 5, 9, 19, 1, 1, 13),
(17, 'Oppo Reno 2', 4, 9, 5, 10, 21, 1, 1, 12),
(18, 'PALM Pepito', 1, 5, 2, 11, 1, 1, 12, 1),
(19, 'Red Hydrogen One', 3, 10, 4, 12, 27, 1, 13, 3),
(20, 'Samsung GALAXY A10', 1, 7, 1, 13, 14, 1, 5, 7),
(21, 'Samsung Galaxy Note 10', 4, 14, 5, 13, 17, 1, 4, 9),
(22, 'Samsung Galaxy Note 9', 3, 13, 5, 13, 22, 1, 3, 9),
(23, 'Samsung Galaxy S10', 3, 13, 5, 13, 15, 1, 14, 6),
(24, 'Samsung Galaxy S10+', 3, 16, 5, 13, 24, 1, 8, 11),
(25, 'Samsung Galaxy S9', 2, 17, 3, 13, 5, 1, 4, 4),
(26, 'Sony Xperia 1', 3, 16, 4, 14, 13, 1, 4, 12),
(27, 'Sony Xperia 5', 3, 16, 4, 14, 9, 1, 4, 6),
(28, 'Vivo X21', 3, 1, 4, 15, 10, 1, 15, 8),
(29, 'Xiaomi BLACK SHARK 2', 3, 18, 5, 16, 23, 1, 16, 10),
(30, 'Xiaomi Mi 9', 2, 11, 4, 16, 11, 1, 12, 10);

DROP TABLE IF EXISTS t_vendor;
CREATE TABLE IF NOT EXISTS t_vendor (
  `idVendor` int(11) NOT NULL AUTO_INCREMENT,
  `venName` varchar(50) NOT NULL,
  PRIMARY KEY (`idVendor`),
  UNIQUE KEY `ID_t_vendor_IND` (`idVendor`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

INSERT INTO t_vendor (idVendor, venName) VALUES
(1, 'Microspot'),
(2, 'Electopolis'),
(3, 'Galaxus'),
(4, 'Mobile Device'),
(5, 'Techmania'),
(6, 'ARP'),
(7, 'Conrad'),
(8, 'PC-Ostchweiz'),
(9, 'Alternate'),
(10, 'Quelle'),
(11, 'Verkaufen'),
(12, 'Foletti Computer Store'),
(13, 'Amazon'),
(14, 'Fust'),
(15, 'Real Star Technology'),
(16, 'Evenshop');


ALTER TABLE t_price
  ADD CONSTRAINT `FKcost_FK` FOREIGN KEY (`fkTelephone`) REFERENCES t_telephone (`idTelephone`);

ALTER TABLE t_telephone
  ADD CONSTRAINT `FKconstitute_FK` FOREIGN KEY (`fkScreen`) REFERENCES t_screen (`idScreen`),
  ADD CONSTRAINT `FKdeliver_FK` FOREIGN KEY (`fkVendor`) REFERENCES t_vendor (`idVendor`),
  ADD CONSTRAINT `FKexploit_FK` FOREIGN KEY (`fkOperativeSystem`) REFERENCES t_operativesystem (`idOperativeSystem`),
  ADD CONSTRAINT `FKhave_FK` FOREIGN KEY (`fkBattery`) REFERENCES t_battery (`idBattery`),
  ADD CONSTRAINT `FKmakeUseOf_FK` FOREIGN KEY (`fkRam`) REFERENCES t_ram (`idRam`),
  ADD CONSTRAINT `FKmake_FK` FOREIGN KEY (`fkManufacturer`) REFERENCES t_manufacturer (`idManufacturer`),
  ADD CONSTRAINT `FKuse_FK` FOREIGN KEY (`fkCPU`) REFERENCES t_cpu (`idCPU`),
  ADD CONSTRAINT `FKutilize_FK` FOREIGN KEY (`fkStorage`) REFERENCES t_storage (`idStorage`);

