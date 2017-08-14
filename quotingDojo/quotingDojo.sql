-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema QuotingDojo
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema QuotingDojo
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `QuotingDojo` ;
USE `QuotingDojo` ;

-- -----------------------------------------------------
-- Table `QuotingDojo`.`Quotes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `QuotingDojo`.`Quotes` (
  `idQuotes` INT NOT NULL,
  `Name` VARCHAR(255) NULL,
  `Context` VARCHAR(255) NULL,
  PRIMARY KEY (`idQuotes`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
CREATE TABLE IF NOT EXISTS `QuotingDojo`.`Quotes` (   `idQuotes` INT NOT NULL,   `Name` VARCHAR(255) NULL,   `Context` VARCHAR(255) NULL,   `create_at`  NULL,   PRIMARY KEY (`idQuotes`)) ENGINE = InnoDB
