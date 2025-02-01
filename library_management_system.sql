-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2025 at 08:11 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_table`
--

CREATE TABLE `admin_table` (
  `Id` int(100) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `email` varchar(35) NOT NULL,
  `phoneNumber` int(10) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_table`
--

INSERT INTO `admin_table` (`Id`, `name`, `password`, `email`, `phoneNumber`, `role`) VALUES
(1, 'lesandu', 'lesandu123', 'lesanduluthmeen@gmail.com', 740713025, 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `books_table`
--

CREATE TABLE `books_table` (
  `ID` int(100) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Author` varchar(20) NOT NULL,
  `Year` int(5) NOT NULL,
  `ISBN` varchar(50) NOT NULL,
  `URL` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books_table`
--

INSERT INTO `books_table` (`ID`, `Title`, `Author`, `Year`, `ISBN`, `URL`) VALUES
(7, 'By - ways of war', 'jeffery Roche', 1986, '9783029464046', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\001.jpg'),
(8, 'Records of Steam Boiler Explosions', 'Edward Bindon Marten', 2015, '9786437878856', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\016.jpg'),
(9, 'KIM', 'unknown', 1985, '9782025774296', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\002.jpg'),
(10, 'Thorn in my side', 'C J S K U S E', 1999, '9781088797051', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\006.jpg'),
(11, 'mahanuwara rajadhaniye', 'manel ranasinghe', 2006, '9785030910284', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\042.jpg'),
(12, 'Effel Tower', 'Robert M .Vogel', 1956, '9789697678624', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\018.jpg'),
(13, 'boss', 'pakaya', 1234, '9784471851965', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\044.jpg'),
(14, 'Farm engines and how to run', 'james h stephenson', 1956, '9783508308519', 'C:\\Users\\lesandu\\OneDrive - Asia Pacific Institute of Information Technology\\Pictures\\images\\021.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `borrowed_records`
--

CREATE TABLE `borrowed_records` (
  `BorrowedId` int(100) NOT NULL,
  `BookId` int(100) NOT NULL,
  `UserId` int(100) NOT NULL,
  `BorrowDate` date NOT NULL,
  `DueDate` date NOT NULL,
  `IsReturned` tinyint(1) NOT NULL,
  `ReturnedDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrowed_records`
--

INSERT INTO `borrowed_records` (`BorrowedId`, `BookId`, `UserId`, `BorrowDate`, `DueDate`, `IsReturned`, `ReturnedDate`) VALUES
(1, 8, 1, '2025-01-31', '2025-02-14', 1, '2025-01-31'),
(2, 8, 1, '2025-01-31', '2025-02-14', 1, '2025-02-21'),
(3, 10, 1, '2025-01-31', '2025-02-14', 1, '2025-02-01'),
(4, 12, 1, '2025-02-01', '2025-02-15', 1, '2025-02-01'),
(5, 9, 2, '2025-02-01', '2025-02-15', 0, '0000-00-00'),
(6, 13, 2, '2025-02-01', '2025-02-15', 0, '0000-00-00'),
(7, 14, 2, '2025-02-01', '2025-02-15', 0, '0000-00-00'),
(8, 11, 2, '2025-02-01', '2025-02-15', 0, '0000-00-00'),
(9, 7, 1, '2025-02-01', '2025-02-15', 1, '2025-02-01');

-- --------------------------------------------------------

--
-- Table structure for table `librarian_table`
--

CREATE TABLE `librarian_table` (
  `Id` int(100) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `email` varchar(35) NOT NULL,
  `phoneNumber` int(10) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `librarian_table`
--

INSERT INTO `librarian_table` (`Id`, `name`, `password`, `email`, `phoneNumber`, `role`) VALUES
(4, 'Librarian', 'lesandu12', 'Librarian@gmail.com', 1234567890, 'Librarian');

-- --------------------------------------------------------

--
-- Table structure for table `overdue_table`
--

CREATE TABLE `overdue_table` (
  `OverdueId` int(100) NOT NULL,
  `BorrowedId` int(100) NOT NULL,
  `UserID` int(100) NOT NULL,
  `BookID` int(100) NOT NULL,
  `OverdueDays` int(100) NOT NULL,
  `FineAmount` decimal(10,0) NOT NULL,
  `PaidStatus` tinyint(1) NOT NULL,
  `PaidDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `overdue_table`
--

INSERT INTO `overdue_table` (`OverdueId`, `BorrowedId`, `UserID`, `BookID`, `OverdueDays`, `FineAmount`, `PaidStatus`, `PaidDate`) VALUES
(1, 2, 1, 8, 7, 35, 1, '2025-02-01');

-- --------------------------------------------------------

--
-- Table structure for table `reservation_table`
--

CREATE TABLE `reservation_table` (
  `ReservationId` int(100) NOT NULL,
  `BookId` int(100) NOT NULL,
  `UserId` int(100) NOT NULL,
  `ReservationDate` date NOT NULL,
  `ReservedUntill` date NOT NULL,
  `Status` varchar(100) NOT NULL,
  `IsCollected` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `student_table`
--

CREATE TABLE `student_table` (
  `Id` int(100) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `email` varchar(35) NOT NULL,
  `phoneNumber` int(10) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_table`
--

INSERT INTO `student_table` (`Id`, `name`, `password`, `email`, `phoneNumber`, `role`) VALUES
(1, 'GuestUser', 'lesandu1', 'lesanduluthmeen@gmail.com', 740713025, 'Student'),
(2, 'lesaBoss', 'lesandu12', 'lesandu@gmail.com', 740713025, 'Student');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_table`
--
ALTER TABLE `admin_table`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `books_table`
--
ALTER TABLE `books_table`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `borrowed_records`
--
ALTER TABLE `borrowed_records`
  ADD PRIMARY KEY (`BorrowedId`);

--
-- Indexes for table `librarian_table`
--
ALTER TABLE `librarian_table`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `overdue_table`
--
ALTER TABLE `overdue_table`
  ADD PRIMARY KEY (`OverdueId`);

--
-- Indexes for table `reservation_table`
--
ALTER TABLE `reservation_table`
  ADD PRIMARY KEY (`ReservationId`);

--
-- Indexes for table `student_table`
--
ALTER TABLE `student_table`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_table`
--
ALTER TABLE `admin_table`
  MODIFY `Id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `books_table`
--
ALTER TABLE `books_table`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `borrowed_records`
--
ALTER TABLE `borrowed_records`
  MODIFY `BorrowedId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `librarian_table`
--
ALTER TABLE `librarian_table`
  MODIFY `Id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `overdue_table`
--
ALTER TABLE `overdue_table`
  MODIFY `OverdueId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `reservation_table`
--
ALTER TABLE `reservation_table`
  MODIFY `ReservationId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `student_table`
--
ALTER TABLE `student_table`
  MODIFY `Id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
