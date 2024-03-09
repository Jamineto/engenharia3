-- phpMyAdmin SQL Dump
-- version 5.1.1deb5ubuntu1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Tempo de geração: 09/03/2024 às 18:05
-- Versão do servidor: 8.0.35-0ubuntu0.22.04.1
-- Versão do PHP: 8.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `engenharia`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto`
--

CREATE TABLE `produto` (
  `pro_codigo` int NOT NULL,
  `pro_descricao` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pro_categoria` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pro_estoque` int NOT NULL DEFAULT '0',
  `pro_preco` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Despejando dados para a tabela `produto`
--

INSERT INTO `produto` (`pro_codigo`, `pro_descricao`, `pro_categoria`, `pro_estoque`, `pro_preco`) VALUES
(1, 'Teste', 'Teste', 1, '50');

-- --------------------------------------------------------

--
-- Estrutura para tabela `produto_venda`
--

CREATE TABLE `produto_venda` (
  `prov_codigo` int NOT NULL,
  `ven_codigo` int NOT NULL,
  `pro_codigo` int NOT NULL,
  `prov_quantidade` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Despejando dados para a tabela `produto_venda`
--

INSERT INTO `produto_venda` (`prov_codigo`, `ven_codigo`, `pro_codigo`, `prov_quantidade`) VALUES
(1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `venda`
--

CREATE TABLE `venda` (
  `ven_codigo` int NOT NULL,
  `ven_datahora` datetime NOT NULL,
  `ven_valortotal` decimal(10,0) NOT NULL,
  `ven_pagamento` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Despejando dados para a tabela `venda`
--

INSERT INTO `venda` (`ven_codigo`, `ven_datahora`, `ven_valortotal`, `ven_pagamento`) VALUES
(1, '2024-03-09 18:04:33', '50', 'PIX');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`pro_codigo`);

--
-- Índices de tabela `produto_venda`
--
ALTER TABLE `produto_venda`
  ADD PRIMARY KEY (`prov_codigo`),
  ADD KEY `ven_codigo` (`ven_codigo`),
  ADD KEY `pro_codigo` (`pro_codigo`);

--
-- Índices de tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`ven_codigo`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `pro_codigo` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `produto_venda`
--
ALTER TABLE `produto_venda`
  MODIFY `prov_codigo` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `ven_codigo` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `produto_venda`
--
ALTER TABLE `produto_venda`
  ADD CONSTRAINT `pro_codigo` FOREIGN KEY (`pro_codigo`) REFERENCES `produto` (`pro_codigo`),
  ADD CONSTRAINT `ven_codigo` FOREIGN KEY (`ven_codigo`) REFERENCES `venda` (`ven_codigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
