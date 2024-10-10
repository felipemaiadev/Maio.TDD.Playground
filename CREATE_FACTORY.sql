
CREATE TABLE `Factory` (
  `Id` varchar(36) NOT NULL,
  `CodRef` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Coutry` varchar(20) DEFAULT NULL,
  `Machines` int DEFAULT NULL,
  `IsActive` bit(1) DEFAULT NULL,
  `AssemblyStamp` date DEFAULT NULL,
  PRIMARY KEY (`CodRef`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
