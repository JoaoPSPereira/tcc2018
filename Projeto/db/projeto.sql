-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 16-Jan-2019 às 02:47
-- Versão do servidor: 10.1.37-MariaDB
-- versão do PHP: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projeto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `admin`
--

CREATE TABLE `admin` (
  `id_admin` int(11) NOT NULL,
  `tag_pessoa` varchar(8) NOT NULL,
  `login_admin` varchar(32) DEFAULT NULL,
  `senha_admin` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `admin`
--

INSERT INTO `admin` (`id_admin`, `tag_pessoa`, `login_admin`, `senha_admin`) VALUES
(2, '90783452', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Estrutura da tabela `entrada`
--

CREATE TABLE `entrada` (
  `id_entrada` int(11) NOT NULL,
  `nome_pessoa` varchar(50) NOT NULL,
  `tag_pessoa` varchar(8) NOT NULL,
  `data_entrada` datetime DEFAULT NULL,
  `data_saida` datetime DEFAULT NULL,
  `id_venda` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `entrada`
--

INSERT INTO `entrada` (`id_entrada`, `nome_pessoa`, `tag_pessoa`, `data_entrada`, `data_saida`, `id_venda`) VALUES
(10, 'Renato Higa Higuti', '8C824669', '2019-01-15 23:32:50', '2019-01-15 23:33:05', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `medicamento`
--

CREATE TABLE `medicamento` (
  `id_medicamento` int(11) NOT NULL,
  `nome_medicamento` varchar(40) NOT NULL,
  `descricao_medicamento` varchar(255) DEFAULT NULL,
  `tipo_medicamento` enum('Sólido Oral','Líquido Oral','Liquido Intravenoso','Outro') NOT NULL,
  `quantidade_caixa` int(11) NOT NULL DEFAULT '1',
  `conteudo_liquido` double NOT NULL,
  `medida_conteudo` enum('mg','ml') NOT NULL,
  `ativo_medicamento` enum('S','N') DEFAULT 'S',
  `qnt_em_estoque` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `medicamento`
--

INSERT INTO `medicamento` (`id_medicamento`, `nome_medicamento`, `descricao_medicamento`, `tipo_medicamento`, `quantidade_caixa`, `conteudo_liquido`, `medida_conteudo`, `ativo_medicamento`, `qnt_em_estoque`) VALUES
(1, 'Remédio', 'Genérico', 'Sólido Oral', 30, 200, 'mg', 'S', 85);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `tag_pessoa` varchar(8) NOT NULL,
  `nome_pessoa` varchar(50) NOT NULL,
  `cpf_pessoa` varchar(14) NOT NULL,
  `rg_pessoa` varchar(12) DEFAULT NULL,
  `cargo_pessoa` enum('Admin','Funcionário') DEFAULT 'Funcionário',
  `ativo_pessoa` enum('S','N') DEFAULT 'S'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`tag_pessoa`, `nome_pessoa`, `cpf_pessoa`, `rg_pessoa`, `cargo_pessoa`, `ativo_pessoa`) VALUES
('8C824669', 'Renato Higa Higuti', '222.123.258-11', '25.485.185-6', 'Funcionário', 'S'),
('90783452', 'João Pedro Santos', '337.267.778-14', '37.545.645-6', 'Admin', 'S');

-- --------------------------------------------------------

--
-- Estrutura da tabela `retirada`
--

CREATE TABLE `retirada` (
  `id_retirada` int(11) NOT NULL,
  `nome_medicamento` varchar(40) NOT NULL,
  `id_medicamento` int(11) NOT NULL,
  `qnt_retirada` int(11) NOT NULL DEFAULT '0',
  `saldo` int(11) NOT NULL,
  `nome_pessoa` varchar(50) NOT NULL,
  `tag_pessoa` varchar(8) NOT NULL,
  `data_retirada` datetime NOT NULL,
  `id_venda` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `retirada`
--

INSERT INTO `retirada` (`id_retirada`, `nome_medicamento`, `id_medicamento`, `qnt_retirada`, `saldo`, `nome_pessoa`, `tag_pessoa`, `data_retirada`, `id_venda`) VALUES
(2, 'Remédio', 1, 5, 85, 'Renato Higa Higuti', '8C824669', '2019-01-15 23:33:05', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `id_venda` int(11) NOT NULL,
  `nome_pessoa` varchar(50) NOT NULL,
  `tag_pessoa` varchar(8) NOT NULL,
  `data_retirada` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`id_venda`, `nome_pessoa`, `tag_pessoa`, `data_retirada`) VALUES
(2, 'Renato Higa Higuti', '8C824669', '2019-01-15 23:33:05');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`),
  ADD KEY `FK_tag_pessoa` (`tag_pessoa`);

--
-- Indexes for table `entrada`
--
ALTER TABLE `entrada`
  ADD PRIMARY KEY (`id_entrada`),
  ADD KEY `FK_tag_pessoa_entrada` (`tag_pessoa`),
  ADD KEY `FK_id_venda_entrada` (`id_venda`);

--
-- Indexes for table `medicamento`
--
ALTER TABLE `medicamento`
  ADD PRIMARY KEY (`id_medicamento`);

--
-- Indexes for table `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`tag_pessoa`);

--
-- Indexes for table `retirada`
--
ALTER TABLE `retirada`
  ADD PRIMARY KEY (`id_retirada`),
  ADD KEY `FK_id_medicamento` (`id_medicamento`),
  ADD KEY `FK_tag_pessoa_retirada` (`tag_pessoa`),
  ADD KEY `FK_id_venda` (`id_venda`);

--
-- Indexes for table `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`id_venda`),
  ADD KEY `FK_tag_pessoa_venda` (`tag_pessoa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `entrada`
--
ALTER TABLE `entrada`
  MODIFY `id_entrada` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `medicamento`
--
ALTER TABLE `medicamento`
  MODIFY `id_medicamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `retirada`
--
ALTER TABLE `retirada`
  MODIFY `id_retirada` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `venda`
--
ALTER TABLE `venda`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `FK_tag_pessoa` FOREIGN KEY (`tag_pessoa`) REFERENCES `pessoa` (`tag_pessoa`);

--
-- Limitadores para a tabela `entrada`
--
ALTER TABLE `entrada`
  ADD CONSTRAINT `FK_id_venda_entrada` FOREIGN KEY (`id_venda`) REFERENCES `venda` (`id_venda`),
  ADD CONSTRAINT `FK_tag_pessoa_entrada` FOREIGN KEY (`tag_pessoa`) REFERENCES `pessoa` (`tag_pessoa`);

--
-- Limitadores para a tabela `retirada`
--
ALTER TABLE `retirada`
  ADD CONSTRAINT `FK_id_medicamento` FOREIGN KEY (`id_medicamento`) REFERENCES `medicamento` (`id_medicamento`),
  ADD CONSTRAINT `FK_id_venda` FOREIGN KEY (`id_venda`) REFERENCES `venda` (`id_venda`),
  ADD CONSTRAINT `FK_tag_pessoa_retirada` FOREIGN KEY (`tag_pessoa`) REFERENCES `pessoa` (`tag_pessoa`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `FK_tag_pessoa_venda` FOREIGN KEY (`tag_pessoa`) REFERENCES `pessoa` (`tag_pessoa`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
