CREATE TABLE `ProductionLine` (
  `Id` varchar(36) NOT NULL,
  `CodRef` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Id_Factory` int NOT NULL,
  `Machines` int DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `AssemblyStamp` date DEFAULT NULL,
  `LastUpdate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `FK_PORDLINE_CODREF_idx` (`Id_Factory`),
  CONSTRAINT `FK_PRODLINE_CODREF` FOREIGN KEY (`Id_Factory`) REFERENCES `Factory` (`CodRef`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;