-- phpMyAdmin SQL Dump
-- version 3.2.0.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 25, 2018 at 10:36 AM
-- Server version: 5.1.36
-- PHP Version: 5.3.0

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `pg`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `department` varchar(10) NOT NULL,
  `caste` varchar(10) NOT NULL,
  `cat` varchar(15) NOT NULL,
  `cname` varchar(30) NOT NULL,
  `fname` varchar(30) NOT NULL,
  `focc` varchar(30) NOT NULL,
  `mname` varchar(30) NOT NULL,
  `addr` varchar(50) NOT NULL,
  `mobno` varchar(15) NOT NULL,
  `email` varchar(30) NOT NULL,
  `dob` varchar(15) NOT NULL,
  `addr1` varchar(50) NOT NULL,
  `empd` varchar(20) NOT NULL,
  `empd2` varchar(20) NOT NULL,
  `ssc_board` varchar(20) NOT NULL,
  `ssc_inst` varchar(20) NOT NULL,
  `ssc_div` varchar(20) NOT NULL,
  `ssc_agg` varchar(20) NOT NULL,
  `ssc_passDate` varchar(20) NOT NULL,
  `im_board` varchar(20) NOT NULL,
  `im_clg` varchar(20) NOT NULL,
  `im_div` varchar(20) NOT NULL,
  `im_agg` varchar(20) NOT NULL,
  `im_passDate` varchar(20) NOT NULL,
  `be_board` varchar(20) NOT NULL,
  `be_clg` varchar(20) NOT NULL,
  `be_div` varchar(20) NOT NULL,
  `be_agg` varchar(20) NOT NULL,
  `be_passDate` varchar(20) NOT NULL,
  `msc_board` varchar(20) NOT NULL,
  `msc_clg` varchar(30) NOT NULL,
  `msc_div` varchar(20) NOT NULL,
  `msc_agg` varchar(20) NOT NULL,
  `msc_passDate` varchar(20) NOT NULL,
  `status` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `department`, `caste`, `cat`, `cname`, `fname`, `focc`, `mname`, `addr`, `mobno`, `email`, `dob`, `addr1`, `empd`, `empd2`, `ssc_board`, `ssc_inst`, `ssc_div`, `ssc_agg`, `ssc_passDate`, `im_board`, `im_clg`, `im_div`, `im_agg`, `im_passDate`, `be_board`, `be_clg`, `be_div`, `be_agg`, `be_passDate`, `msc_board`, `msc_clg`, `msc_div`, `msc_agg`, `msc_passDate`, `status`) VALUES
(1, 'CSE', 'OC', 'local', 'akheel', 'Nasar', 'as', 'dabcng', 'hyd', '8125508446', 'syedakheel01@gmail.com', '1991-12-04', 'hyd', 'asd', 'bhdc', 'ssc', 'bhs', 'a', '90', '2010', 'bie', 'sd', 'a', '90', '2012', 'bdjc', 'nmc', 'a', '88', '2014', 'vhas', 'sc', 's', '77', '2016', ''),
(2, 'CSE', 'OC', 'local', 'asdf', 'asfg', 'fg', 'sdf', 'hyd', '876543478', 'syd@gmail.com', '1991-12-04', 'hyd', 'hcd', 'dsc', 'ssc', 'vbhdc', 'asc', '90', '2010', 'biv', 'bhc', 'bnzxc', '99', '2012', 'dcbv', 'bnzdc', 'njzxc', '88', '2014', 'bjndc', 'bnxzc', 'nc', '78', '2016', 'pending'),
(3, 'CSE', 'OC', 'local', 'shanu', 'bjn', 'bjn', 'bjmad', 'hyd', '987654546', 'dc@dn.dc', '2005-12-04', 'hyd', 'bjhx', 'baxb', 'bjxs', 'nx', 'bhjx', '90', '2008', 'bm', 'bnxc', 'x', '99', '2010', 'bjdc', 'macsxcs', 's', '98', '2014', 'adc', 'dxc', 's', '90', '2106', 'pending'),
(4, 'ECE', 'BCA', 'local', 'bjasfd', 'bnzdc', 'bnzjdc', 'bnsc', 'hyd', '9876554', 'bs@mdg.df', '2005-12-04', 'hyd', 'bjdc', 'bjzxc', 'zxc', 'zxc', 'zxc', '90', '2010', 'dsfdsf', 'sdfv', 'ds', '99', '2012', 'ds', 'nmzdc', 'zc', '78', '2016', 'bjdc', 'hcd', 'd', '78', '2017', 'pending');
