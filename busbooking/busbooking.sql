-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 06, 2020 at 02:44 AM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `busbooking`
--

-- --------------------------------------------------------

--
-- Table structure for table `audit`
--

CREATE TABLE `audit` (
  `id` int(11) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT current_timestamp(),
  `type` varchar(500) NOT NULL,
  `userID` int(11) NOT NULL,
  `description` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `audit`
--

INSERT INTO `audit` (`id`, `timestamp`, `type`, `userID`, `description`) VALUES
(1, '2020-11-03 13:20:43', 'INSERT', 5, 'New booking ID 1 created on customer 1'),
(2, '2020-11-03 13:20:43', 'UPDATE', 5, 'Changes on booking ID 1'),
(3, '2020-11-04 17:11:36', 'UPDATE', 5, 'Changes on booking ID 0\nChanges on status from PENDING to BOOKED BUT NOT PAID\n'),
(4, '2020-11-04 17:21:31', 'UPDATE', 5, 'Changes on booking ID 0\nChanges on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n'),
(5, '2020-11-04 23:55:26', 'UPDATE', 5, 'Changes on booking ID 0\nChanges on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n'),
(6, '2020-11-04 23:58:45', 'UPDATE', 5, 'Changes on booking ID 0\nChanges on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n'),
(7, '2020-11-05 00:22:04', 'INSERT', 5, 'New booking ID 4 created on customer 1154865691'),
(8, '2020-11-05 00:26:30', 'UPDATE', 14, 'Changes on booking ID 4\nChanges on status from CANCEL to BOOKED BUT NOT PAID\n'),
(9, '2020-11-05 00:26:55', 'UPDATE', 14, 'Changes on booking ID 1\nChanges on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n'),
(10, '2020-11-05 00:29:21', 'UPDATE', 14, 'Changes on booking ID 4\nChanges on arrivalDate from 11/12/2020 12:00:00 AM to 2020-11-12\n'),
(11, '2020-11-05 00:31:38', 'INSERT', 14, 'New booking ID 5 created on customer 102881145'),
(12, '2020-11-05 00:32:12', 'UPDATE', 14, 'Changes on booking ID 5\nChanges on driver2  from 3 to 2\n'),
(13, '2020-11-05 00:32:19', 'UPDATE', 14, 'Changes on booking ID 5\nChanges on driver2  from 3 to 2\n'),
(14, '2020-11-05 00:47:58', 'INSERT', 14, 'New booking ID 6 created on customer 102881145'),
(15, '2020-11-05 00:51:54', 'UPDATE', 14, 'Changes on booking ID 6\nChanges on arrivalDate from 11/5/2020 12:00:00 AM to 2020-11-05\n'),
(16, '2020-11-05 00:52:44', 'UPDATE', 14, 'Changes on booking ID 5\nChanges on status from BOOKED to BOOKED BUT NOT PAID\n'),
(17, '2020-11-05 01:51:03', 'INSERT', 14, 'New booking ID 7 created on customer 102881145'),
(18, '2020-11-05 01:53:45', 'INSERT', 14, 'New booking ID 8 created on customer 102881145'),
(19, '2020-11-05 04:46:00', 'INSERT', 14, 'New booking ID 9 created on customer 102881145'),
(20, '2020-11-05 04:47:26', 'INSERT', 14, 'New booking ID 10 created on customer 1123716533'),
(21, '2020-11-05 04:48:24', 'INSERT', 14, 'New booking ID 11 created on customer 1154865691'),
(22, '2020-11-05 04:49:16', 'INSERT', 14, 'New booking ID 12 created on customer 150435948'),
(23, '2020-11-06 01:30:29', 'INSERT', 14, 'New booking ID 23 created on customer 102881145');

-- --------------------------------------------------------

--
-- Table structure for table `booking`
--

CREATE TABLE `booking` (
  `id` int(11) NOT NULL,
  `cusID` int(11) NOT NULL,
  `passenger` int(4) NOT NULL,
  `remarks` text NOT NULL,
  `departureDate` date NOT NULL,
  `departureTime` time NOT NULL,
  `departureLocation` text NOT NULL,
  `arrivalDate` date NOT NULL,
  `arrivalTime` time NOT NULL,
  `arrivalLocation` text NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `status` varchar(20) NOT NULL DEFAULT 'PENDING',
  `provider` int(11) DEFAULT NULL,
  `vehicle` varchar(10) DEFAULT NULL,
  `driver1` int(11) DEFAULT NULL,
  `driver2` int(11) DEFAULT NULL,
  `paid` int(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `booking`
--

INSERT INTO `booking` (`id`, `cusID`, `passenger`, `remarks`, `departureDate`, `departureTime`, `departureLocation`, `arrivalDate`, `arrivalTime`, `arrivalLocation`, `createdAt`, `status`, `provider`, `vehicle`, `driver1`, `driver2`, `paid`) VALUES
(9, 102881145, 8, '', '2020-09-04', '08:00:00', '825 Bagan Lallang 13400 Butterworth Pulau Pinang Malaysia', '2020-09-16', '20:00:00', '21A 1St Floor Jln Ibrahim 08000 Sungai Petani Kedah Sungai Petani Kedah 08000 Malaysia', '2020-08-05 04:46:00', 'BOOKED', 1, 'GCN4982', 1, 2, 1),
(10, 1123716533, 20, '', '2020-10-01', '10:00:00', 'Jalan Mahkota, Taman Maluri, Off Jalan Cheras', '2020-10-14', '18:00:00', '34 Lrg Jati 20A Taman Bandar Baru 08100 Sungai Lalang 08100 Malaysia Bedong Kedah 08100 Malaysia', '2020-08-05 04:47:26', 'BOOKED BUT NOT PAID', 1, 'EMP0661', 1, 3, 0),
(11, 1154865691, 10, '', '2020-11-24', '10:00:00', 'No. 65 Jln Nilam 1/2 Taman Teknologi Tinggi Subang 40000 Shah Alam Shah Alam 40000 Malaysia', '2020-11-27', '22:00:00', 'M Bangunan Uda Bandar Baru Ampangan 70400 Negeri Sembilan 70400 Malaysia', '2020-08-05 04:48:24', 'PENDING', NULL, NULL, NULL, NULL, 1),
(12, 150435948, 6, '', '2020-11-01', '08:00:00', '11 Lrg Ramal 1/1 Taman Ramal Indah 43000 43000 Malaysia 43000 Malaysia', '2020-11-02', '08:00:00', 'A14 Jln Semantan 1 Lurah Semantan 28000 Temerloh Temerloh Pahang 28000 Malaysia Temerloh Pahang 2800', '2020-08-05 04:49:16', 'CANCEL', 1, 'PCT0080', 2, 4, 1),
(13, 190088536, 10, '', '2020-12-01', '10:00:00', '1St Floor Bersatu Shopping Centre Bhd Jln Tok Hakim 15000 Kota Bharu Kelantan Kota Bharu Kelantan 15', '2020-12-04', '22:00:00', '1st Floor, Jln 8/125d, 57100 Kuala Lumpur', '2020-08-05 04:48:24', 'PENDING', NULL, NULL, NULL, NULL, 1),
(14, 190088536, 6, '', '2020-11-13', '08:00:00', 'N0 37 JALAN STATION 44200 RASA', '2020-11-17', '08:00:00', 'Kampung Baru Balakong, Off Batu 13, Jalan Sungai Besi', '2020-08-05 04:49:16', 'CANCEL', 2, 'GRQ8053', 6, 8, 1),
(15, 102881145, 6, '', '2020-11-13', '08:00:00', 'Kompleks Sukan Maudzamshah 05400 Alor Setar Kedah Malaysia', '2020-11-17', '08:00:00', '4243C Jln Batu Berendam 75350 Batu Berendam 75350 Malaysia Melaka Melaka 75350 Malaysia', '2020-08-05 04:49:16', 'CANCEL', 4, 'DME8675', 10, 12, 1),
(16, 1123716533, 6, '', '2020-11-13', '08:00:00', 'No. 16, Jalan 8/6, 46050\r\nPetaling Jaya, Selangor, 46050', '2020-11-17', '08:00:00', '3 BLOK E CHERAS BUSINESS CENTRE JLN 1/101C 56100 Wilayah Persekutuan 56100 Malaysia', '2020-08-05 04:49:16', 'CANCEL', 7, 'XQY9334', 14, 16, 1),
(17, 150435948, 8, '', '2020-09-04', '08:00:00', 'No. 10 Jalan Tan Khim Seck Kluang Baru Kluang, Johor Bahru, Johor, 86000', '2020-09-16', '20:00:00', '31-2 Jln 46A/26 Rampai Town Centre Tmn Sri Rampai 53300 Wilayah Persekutuan Malaysia', '2020-08-05 04:46:00', 'BOOKED', 2, 'GWC4457', 5, 6, 1),
(18, 1154865691, 20, '', '2020-10-01', '10:00:00', '36 Kampung Sari Kuala Klawang 71600 Jelebu Negeri Sembilan Malaysia', '2020-10-14', '18:00:00', 'Sungei Way Brewery 9Th Mile Old Road 46000, Petaling Jaya, Selangor, 46000', '2020-08-05 04:47:26', 'BOOKED BUT NOT PAID', 2, 'HIQ1056', 5, 7, 0),
(19, 190088536, 8, '', '2020-09-04', '08:00:00', '2565B Jln Putera Batu 14 1/2 06250 Alor Setar Kedah Alor Setar Kedah 06250 Malaysia', '2020-09-16', '20:00:00', 'No. 29 Jln Kuchai Lama Taman Lian Hoe 58200 Wilayah Persekutuan 58200 Malaysia', '2020-08-05 04:46:00', 'BOOKED', 4, 'WYJ1867', 9, 10, 1),
(20, 1123716533, 20, '', '2020-10-01', '10:00:00', '4673 Jln Rawang Batu 7 3/4 68100 Selayang 68100 Malaysia Batu Caves 68100 Malaysia\r\n\r\n', '2020-10-14', '18:00:00', '1899B Jln Kuala Besut Kampung Pengkalan Nyireh 22200 Besut 22200 Malaysia Kampong Raja Terengganu 22', '2020-08-05 04:47:26', 'BOOKED BUT NOT PAID', 4, 'QKA4476', 9, 11, 0),
(21, 150435948, 8, '', '2020-09-04', '08:00:00', '11 Level 1 Wisma Cosway Jalan Raja Chulan 50200 Wilayah Persekutuan Malaysia', '2020-09-16', '20:00:00', '28 Jalan Seksyen Kampung Melayu Majidee 81100 Johor Malaysia', '2020-08-05 04:46:00', 'BOOKED', 7, 'TAF3117', 13, 14, 1),
(22, 1154865691, 20, '', '2020-10-01', '10:00:00', '4723 JLN BAGAN LALLANG 13400 BUTTERWORTH Butterworth Penang 13400 Malaysia', '2020-10-14', '18:00:00', '4 Jln Tengku Rahim 16800 Pasir Puteh Pasir Puteh Kelantan 16800 Malaysia Pasir Puteh Kelantan 16800', '2020-08-05 04:47:26', 'BOOKED BUT NOT PAID', 7, 'PSZ1993', 13, 15, 0),
(23, 102881145, 1, '', '2020-11-06', '00:00:00', '1', '2020-11-06', '00:00:00', '1', '2020-11-06 01:30:29', 'BOOKED', 1, 'EMP0661', 2, 3, 1);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `phoneNum` varchar(20) NOT NULL,
  `name` varchar(200) NOT NULL,
  `IC` varchar(12) NOT NULL,
  `email` varchar(320) NOT NULL,
  `bankAcc` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`phoneNum`, `name`, `IC`, `email`, `bankAcc`) VALUES
('102881145', 'Harland Gaze	', '830613033286', 'shaoqi.cheah@gmail.com', '8659756505538238'),
('1123716533', 'Jacklyn Brisco', '970929003637', 'jbrisco4@umich.edu', '7385156342506031'),
('1154865691', 'Yoshiko Runsey', '850808007834', 'yrunseyc@sciencedaily.com', NULL),
('150435948', 'Randal MacTerlagh', '870213024952', 'rmacterlagh3@cnet.com', NULL),
('190088536', 'Isadora Speeks', '940725017529', 'ispeeks8@wordpress.com', '2163327146581757');

-- --------------------------------------------------------

--
-- Table structure for table `driver`
--

CREATE TABLE `driver` (
  `id` int(11) NOT NULL,
  `IC` varchar(12) NOT NULL,
  `name` varchar(200) NOT NULL,
  `licenseNo` varchar(20) NOT NULL,
  `class` varchar(10) NOT NULL,
  `phoneNum` varchar(20) NOT NULL,
  `provider` int(11) NOT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'FREE',
  `reason` text DEFAULT NULL,
  `image` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `driver`
--

INSERT INTO `driver` (`id`, `IC`, `name`, `licenseNo`, `class`, `phoneNum`, `provider`, `status`, `reason`, `image`) VALUES
(1, '830716013076', 'Valentine Dudeney	', '9590329', 'B', '127833968', 1, 'FREE', NULL, 'outdoors-man-portrait_-cropped-jpg.jpg'),
(2, '970509066313', 'Farlie Mulhall	', '2703036', 'B', '127278640', 1, 'FREE', NULL, NULL),
(3, '870129091516', 'Gauthier Weippert	', '7984308', 'B', '129372369', 1, 'FREE', NULL, NULL),
(4, '960308076751', 'Amalee Aikin', '0803021', 'B', '1109508324', 1, 'FREE', NULL, NULL),
(5, '950706042441', 'Alverta Moohan', '1624279', 'B', '1108992698', 2, 'FREE', NULL, NULL),
(6, '860613030216', 'Thorn Juza', '2771125', 'B', '1188200577', 2, 'FREE', NULL, NULL),
(7, '810518026315', 'Wendie Bahls', '2852951', 'B', '1138297491', 2, 'FREE', NULL, NULL),
(8, '720125081094', 'Susanetta Rawsthorne', '9243315', 'B', '1169304059', 2, 'FREE', NULL, NULL),
(9, '820609019104', 'Parsifal Newgrosh', '8674320', 'B', '1110177158', 4, 'FREE', NULL, NULL),
(10, '890817089539', 'Dru Masse', '3605325', 'B', '126581380', 4, 'FREE', NULL, NULL),
(11, '720401083204', 'Rowland Berthon', '3553689', 'B', '1150427964', 4, 'FREE', NULL, NULL),
(12, '830226093479', 'Adey Lambird', '3266020', 'B', '1176282465', 4, 'FREE', NULL, NULL),
(13, '920706056933', 'Rockey Bonhill', '2670095', 'B', '1133019473', 7, 'FREE', NULL, NULL),
(14, '900909083871', 'Melany Akerman', '6039956', 'B', '186136550', 7, 'FREE', NULL, NULL),
(15, '840706085832', 'Wakefield Eagger', '2578919', 'B', '146881824', 7, 'FREE', NULL, NULL),
(16, '800102081387', 'Otes McCritchie', '9295036', 'B', '195887064', 7, 'FREE', NULL, NULL),
(17, '780308049283', 'Wynny Aire', '157411', 'B', '107731987', 8, 'FREE', NULL, NULL),
(18, '831209092389', 'Ross Mabee', '128251', 'B', '131994213', 9, 'FREE', NULL, NULL),
(19, '900903089032', 'Mariel Towell', '188115', 'B', '179285418', 10, 'FREE', NULL, NULL),
(20, '930203038392', 'Eldon Ellingham', '111375', 'B', '131273155', 10, 'FREE', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `notification`
--

CREATE TABLE `notification` (
  `id` int(11) NOT NULL,
  `recipient` int(11) NOT NULL,
  `title` varchar(500) NOT NULL,
  `description` text NOT NULL,
  `isRead` tinyint(1) NOT NULL DEFAULT 0,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `notification`
--

INSERT INTO `notification` (`id`, `recipient`, `title`, `description`, `isRead`, `createdAt`) VALUES
(1, 1, 'test', 'test2', 1, '2020-11-03 01:34:04'),
(2, 2, 'test', 'test2', 1, '2020-11-03 01:34:07'),
(3, 1, 'Mileage Checking on 123', 'Mileage exceed by 7011', 0, '2020-11-03 09:02:26'),
(4, 1, 'Mileage Checking on 123', 'Mileage exceed by 7011', 0, '2020-11-03 09:19:35'),
(5, 1, 'Mileage Checking on 123', 'Mileage exceed by 7011', 0, '2020-11-03 09:20:21'),
(6, 1, 'Permit checking on 12', 'Permit will be expire in -30 days.', 0, '2020-11-03 09:20:21'),
(7, 1, 'Permit checking on 123', 'Permit will be expire in -30 days.', 0, '2020-11-03 09:20:21'),
(8, 1, 'Permit checking on 1234', 'Permit will be expire in -30 days.', 0, '2020-11-03 09:20:21'),
(9, 1, 'Permit checking on 124', 'Permit will be expire in -30 days.', 0, '2020-11-03 09:20:21'),
(10, 1, 'Mileage Checking on 123', 'Mileage exceed by 7011', 0, '2020-11-03 09:21:43'),
(11, 1, 'Permit checking on 12', 'Permit expired,please renew as soon as possible.', 0, '2020-11-03 09:21:43'),
(12, 1, 'Permit checking on 123', 'Permit expired,please renew as soon as possible.', 0, '2020-11-03 09:21:43'),
(13, 1, 'Permit checking on 1234', 'Permit expired,please renew as soon as possible.', 0, '2020-11-03 09:21:43'),
(14, 1, 'Permit checking on 124', 'Permit expired,please renew as soon as possible.', 0, '2020-11-03 09:21:43'),
(15, 0, 'Changes on booking ID 0', 'Changes on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n', 0, '2020-11-04 23:55:26'),
(16, 0, 'Changes on booking ID 0', 'Changes on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n', 0, '2020-11-04 23:58:44'),
(17, 0, 'Changes on booking ID 1', 'Changes on arrivalDate from 10/10/2020 12:00:00 AM to 2020-10-10\n', 0, '2020-11-05 00:26:55'),
(18, 0, 'Changes on booking ID 6', 'Changes on arrivalDate from 11/5/2020 12:00:00 AM to 2020-11-05\n', 0, '2020-11-05 00:51:54');

-- --------------------------------------------------------

--
-- Table structure for table `provider`
--

CREATE TABLE `provider` (
  `id` int(11) NOT NULL,
  `company` varchar(500) DEFAULT NULL,
  `name` varchar(200) NOT NULL,
  `ic` varchar(12) NOT NULL,
  `phoneNum` varchar(20) NOT NULL,
  `email` varchar(320) DEFAULT NULL,
  `image` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `provider`
--

INSERT INTO `provider` (`id`, `company`, `name`, `ic`, `phoneNum`, `email`, `image`) VALUES
(1, 'SBC Shuttle Bus', 'Eddie Scolding', '990113092072', '134315915', 'shaoqi.cheah@gmail.com', 'outdoors-man-portrait_-cropped-jpg.jpg'),
(2, 'Amazon', 'Rudd Geekin', '860925019629', '1168649021', 'rgeekina@amazon.co.jp', NULL),
(4, 'Fiveclub', 'Archie Klemensiewicz', '850924067794', '137187247', 'aklemensiewicz7@cisco.com', NULL),
(7, 'Fatz', 'Giovanni Tarquinio', '930704008756', '155564825', 'gtarquiniob@rambler.ru', NULL),
(8, 'Flashdog', 'Pippy Pankhurst.', '790101020405', '197186448', 'ppankhurst1@a8.net', NULL),
(9, 'Blogtag', 'Horatio Luther', '880808080808', '164254649', 'hluther5@yahoo.com', NULL),
(10, 'Zoomdog', 'Mikey Maestro', '920303091833', '134960105', 'mmaestroa@berkeley.edu', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `id` int(11) NOT NULL,
  `vehicle` varchar(10) NOT NULL,
  `reason` text NOT NULL,
  `description` text NOT NULL,
  `startDate` date NOT NULL,
  `endDate` date NOT NULL,
  `type` varchar(20) NOT NULL DEFAULT 'MAINTENANCE',
  `mileage` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`id`, `vehicle`, `reason`, `description`, `startDate`, `endDate`, `type`, `mileage`) VALUES
(4, 'EMP0661', 'Mileage check', '', '2020-09-29', '2020-09-29', 'MILEAGE', 10000),
(5, 'PCT0080', 'Full maintenance', 'Some part seems rosak', '2020-06-04', '2020-09-04', 'MAINTENANCE', NULL),
(6, 'GCN4982', 'Mileage check', '', '2020-10-03', '2020-10-03', 'MILEAGE', 22000),
(7, 'PCT0080', 'Mileage check', '', '2020-10-01', '2020-10-01', 'MILEAGE', 50000);

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `id` int(11) NOT NULL,
  `skey` varchar(200) NOT NULL,
  `svalue` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`id`, `skey`, `svalue`) VALUES
(5, 'permitDayBefore', '14'),
(6, 'mileageLimit', '8000'),
(7, 'lastDateCheck', '2020-11-02');

-- --------------------------------------------------------

--
-- Table structure for table `user_account`
--

CREATE TABLE `user_account` (
  `id` int(11) NOT NULL,
  `provider` int(11) DEFAULT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `acc_type` varchar(10) NOT NULL DEFAULT 'PROVIDER',
  `date_created` timestamp NOT NULL DEFAULT current_timestamp(),
  `status` varchar(10) NOT NULL DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_account`
--

INSERT INTO `user_account` (`id`, `provider`, `username`, `password`, `acc_type`, `date_created`, `status`) VALUES
(5, NULL, 'admin1', '$2a$11$WjlOuAWcRDHhUWwgCoVMBeMrEgxAFudPBo1LCn8rYpWvoX4rvj1VG', 'ADMIN', '2020-09-24 16:25:00', 'ACTIVE'),
(6, NULL, 'admin2', '$2a$11$RhO6o0L8JinTizrNIJ0YLeGzVKilbN84LkQByyva249kJcZ3Z6i8S', 'ADMIN', '2020-09-24 16:27:20', 'ACTIVE'),
(7, 1, 'SBCuAeL9', '$2a$11$oJomjfqkwofOSKO8HTS4G.1Tq8Jb08AnrwIxlM62WZZd1pFF/EJSG', 'PROVIDER', '2020-11-02 13:50:11', 'ACTIVE'),
(11, 2, 'SBCpXT4s', '$2a$11$lzQtyWUw0QnHVLhEVEUk0eOL9mJg021MiZmsDZX3uRU0g0nFCXikC', 'PROVIDER', '2020-11-05 01:01:22', 'ACTIVE'),
(12, 4, 'SBCw95CU', '$2a$11$XbVpr3kgyFl.oapTCT31GORLZav9KYxSylaWCQflggSMD00uAc6RS', 'PROVIDER', '2020-11-05 01:16:42', 'ACTIVE'),
(13, 7, 'SBC4S@gS', '$2a$11$DNKSNNI9OdhxNs0xpMLNlePDuc5Ug1HIpz8zN7Rd3hPRYFHQ2QM9m', 'PROVIDER', '2020-11-05 01:19:13', 'ACTIVE'),
(14, NULL, 'admin3', '$2a$11$Dcur5N7PTfNzlMMwojF7Lug3dH5uz9Kw4kn7kHDqinEXdWFCZStDK', 'ADMIN', '2020-11-05 01:34:51', 'ACTIVE'),
(15, NULL, 'admin4', '$2a$11$YvNlsL8M6fcqcdt.ujPeKu2OtR6bLzkEK3XSZJYjKi7VYpJklkHRO', 'ADMIN', '2020-11-05 01:36:23', 'ACTIVE'),
(16, 8, 'SBCHoq$U', '$2a$11$BYgblXUzsQ1qpXYl0G0r3.eHymBBviPuLHMuUaGP8LQQcpDZb2pO2', 'PROVIDER', '2020-11-05 16:26:55', 'ACTIVE'),
(17, 9, 'SBCaWliG', '$2a$11$Scu6FfklIO4.XMsGp8CSguRW7CqCERoWWL7ReDxrgELihlGthGhiO', 'PROVIDER', '2020-11-05 16:31:28', 'ACTIVE'),
(18, 10, 'SBCpNDd@', '$2a$11$Jo6T7WGWjqSIzQjsmK/LG.gmwtS7sppaWfJQYKMDXXEPYf1z6Mdb2', 'PROVIDER', '2020-11-05 16:38:00', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle`
--

CREATE TABLE `vehicle` (
  `plateNo` varchar(10) NOT NULL,
  `provider` int(11) NOT NULL,
  `category` varchar(50) NOT NULL,
  `capacity` int(4) NOT NULL,
  `specification` text NOT NULL,
  `permitNo` int(20) DEFAULT NULL,
  `PFromDate` date DEFAULT NULL,
  `PExpiryDate` date DEFAULT NULL,
  `roadtax` int(11) DEFAULT NULL,
  `RExpiryDate` date DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'AVAILABLE',
  `mileage` int(11) DEFAULT NULL,
  `insuranceNo` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `vehicle`
--

INSERT INTO `vehicle` (`plateNo`, `provider`, `category`, `capacity`, `specification`, `permitNo`, `PFromDate`, `PExpiryDate`, `roadtax`, `RExpiryDate`, `status`, `mileage`, `insuranceNo`) VALUES
('DME8675', 4, 'MPV', 6, 'luxury', NULL, '2019-03-02', '2020-11-02', NULL, '2022-06-08', 'AVAILABLE', NULL, NULL),
('EMP0661', 1, 'Express Bus', 38, 'on-bus toilet', 771125, '2019-03-12', '2021-03-12', 56347094, '2021-03-12', 'AVAILABLE', 20000, '54579584116'),
('GCN4982', 1, 'Passenger Van', 10, '', 276182, '2018-04-08', '2020-04-08', 57956603, '2020-04-08', 'AVAILABLE', 28000, '87116206313'),
('GRQ8053', 2, 'MPV', 6, 'luxury', NULL, '2019-03-02', '2020-11-02', NULL, '2020-11-02', 'AVAILABLE', NULL, NULL),
('GWC4457', 2, 'Passenger Van', 10, '', NULL, '2018-04-08', '2020-04-08', NULL, '2020-04-08', 'AVAILABLE', NULL, NULL),
('HIQ1056', 2, 'Express Bus', 38, 'on-bus toilet', NULL, '2019-03-12', '2021-03-12', NULL, '2021-03-12', 'AVAILABLE', NULL, NULL),
('ILJ0921', 1, 'Mini Bus', 20, '', 313929, '2017-05-05', '2022-05-05', 65701796, '2019-04-23', 'AVAILABLE', 500, '770818059559'),
('KVI8239', 8, 'School bus', 20, '', 0, '2020-10-04', '2020-10-04', 0, '2020-10-04', 'AVAILABLE', 0, ''),
('LCO7288', 7, 'Mini Bus', 20, '', NULL, '2017-05-05', '2022-05-05', NULL, '2019-04-23', 'AVAILABLE', NULL, NULL),
('PCT0080', 1, 'MPV', 6, 'luxury', 948688, '2019-03-02', '2020-03-02', 61630708, '2022-06-08', 'AVAILABLE', 110000, '09479041272'),
('PSZ1993', 7, 'Express Bus', 38, 'on-bus toilet', NULL, '2019-03-12', '2021-03-12', NULL, '2021-03-12', 'AVAILABLE', NULL, NULL),
('QKA4476', 4, 'Express Bus', 38, 'on-bus toilet', NULL, '2019-03-12', '2021-03-12', NULL, '2021-03-12', 'AVAILABLE', NULL, NULL),
('STO7957', 10, 'Passenger Van', 7, '', 0, '2020-10-04', '2020-10-04', 0, '2020-10-04', 'AVAILABLE', 0, ''),
('TAF3117', 7, 'Passenger Van', 10, '', NULL, '2018-04-08', '2020-04-08', NULL, '2020-04-08', 'AVAILABLE', NULL, NULL),
('UAG0908', 2, 'Mini Bus', 20, '', NULL, '2017-05-05', '2022-05-05', NULL, '2019-04-23', 'AVAILABLE', NULL, NULL),
('VUV3958', 9, 'Express Bus', 30, '', 0, '2020-10-04', '2020-10-04', 0, '2020-10-04', 'AVAILABLE', 0, ''),
('VWP4239', 4, 'Mini Bus', 20, '', NULL, '2017-05-05', '2022-05-05', NULL, '2019-04-23', 'AVAILABLE', NULL, NULL),
('WYJ1867', 4, 'Passenger Van', 10, '', NULL, '2018-04-08', '2020-04-08', NULL, '2020-04-08', 'AVAILABLE', NULL, NULL),
('XQY9334', 7, 'MPV', 6, 'luxury', NULL, '2019-03-02', '2020-11-02', NULL, '2022-06-08', 'AVAILABLE', NULL, NULL),
('ZPC1316', 10, 'Passenger Van', 8, '', 0, '2020-10-04', '2020-10-04', 0, '2020-10-04', 'AVAILABLE', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `verification`
--

CREATE TABLE `verification` (
  `id` int(11) NOT NULL,
  `token` varchar(500) NOT NULL,
  `email` varchar(320) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `verification`
--

INSERT INTO `verification` (`id`, `token`, `email`, `createdAt`) VALUES
(2, '6ebc54a39d8b3c42f86cfd9fac890c94', 'shaoqi.cheah@gmail.com', '2020-11-05 08:22:23');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `audit`
--
ALTER TABLE `audit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `booking`
--
ALTER TABLE `booking`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`phoneNum`);

--
-- Indexes for table `driver`
--
ALTER TABLE `driver`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `notification`
--
ALTER TABLE `notification`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user_account`
--
ALTER TABLE `user_account`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`plateNo`);

--
-- Indexes for table `verification`
--
ALTER TABLE `verification`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `audit`
--
ALTER TABLE `audit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `booking`
--
ALTER TABLE `booking`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `driver`
--
ALTER TABLE `driver`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `notification`
--
ALTER TABLE `notification`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `provider`
--
ALTER TABLE `provider`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `service`
--
ALTER TABLE `service`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `settings`
--
ALTER TABLE `settings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `user_account`
--
ALTER TABLE `user_account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `verification`
--
ALTER TABLE `verification`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
