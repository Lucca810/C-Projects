-- Database: `pi 3 sem`
--
CREATE DATABASE IF NOT EXISTS `pi 3 sem` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `pi 3 sem`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `cnpj_Fornecedor` char(14) NOT NULL,
  `nome_Fornecedor` varchar(45) NOT NULL,
  `logradouro_Fornecedor` varchar(100) NOT NULL,
  `numero_Fornecedor` int(11) NOT NULL,
  `complemento_Fornecedor` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `log_produto_fornecedor`
--

CREATE TABLE `log_produto_fornecedor` (
  `cod_Log` int(11) NOT NULL,
  `cod_Produto` int(11) NOT NULL,
  `cnpj_Fornecedor` char(14) NOT NULL,
  `qtd_Alterada` int(11) NOT NULL,
  `tipo_Log` enum('Entrada','Saida') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `cod_Produto` int(11) NOT NULL,
  `desc_Produto` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_fornecedor`
--

CREATE TABLE `produto_fornecedor` (
  `cod_Produto` int(11) NOT NULL,
  `cnpj_Fornecedor` char(14) NOT NULL,
  `qtd_Produto` int(11) NOT NULL,
  `qtd_Produto_Min` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`cnpj_Fornecedor`);

--
-- Indexes for table `log_produto_fornecedor`
--
ALTER TABLE `log_produto_fornecedor`
  ADD PRIMARY KEY (`cod_Log`),
  ADD KEY `fk_Entrada_Saida_Produto_Fornecedore1_idx` (`cod_Produto`,`cnpj_Fornecedor`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`cod_Produto`);

--
-- Indexes for table `produto_fornecedor`
--
ALTER TABLE `produto_fornecedor`
  ADD PRIMARY KEY (`cod_Produto`,`cnpj_Fornecedor`),
  ADD KEY `fk_produtos_has_fornecedores_fornecedores1_idx` (`cnpj_Fornecedor`),
  ADD KEY `fk_produtos_has_fornecedores_produtos_idx` (`cod_Produto`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `log_produto_fornecedor`
--
ALTER TABLE `log_produto_fornecedor`
  MODIFY `cod_Log` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `cod_Produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `log_produto_fornecedor`
--
ALTER TABLE `log_produto_fornecedor`
  ADD CONSTRAINT `fk_Entrada_Saida_Produto_Fornecedore1` FOREIGN KEY (`cod_Produto`,`cnpj_Fornecedor`) REFERENCES `produto_fornecedor` (`cod_Produto`, `cnpj_Fornecedor`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `produto_fornecedor`
--
ALTER TABLE `produto_fornecedor`
  ADD CONSTRAINT `fk_produtos_has_fornecedores_fornecedores1` FOREIGN KEY (`cnpj_Fornecedor`) REFERENCES `fornecedor` (`cnpj_Fornecedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_produtos_has_fornecedores_produtos` FOREIGN KEY (`cod_Produto`) REFERENCES `produto` (`cod_Produto`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;
