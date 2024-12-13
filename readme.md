# DOQR Application

Este repositório contém a aplicação DOQR com um back-end em .NET e front-end em React. Para rodar a aplicação localmente, você precisará do Docker e Docker Compose instalados.

## Estrutura do Repositório

A aplicação está dividida nas seguintes pastas:

- **doqr-back**: Contém o código do back-end em .NET.
- **next-app**: Contém o código do front-end em React (Next.js).

# Requisitos

Antes de rodar a aplicação, certifique-se de que você tem as seguintes ferramentas instaladas:

- **[Docker](https://www.docker.com/get-started)** (versão 20.10 ou superior)
- **[Docker Compose](https://docs.docker.com/compose/install/)** (versão 1.29 ou superior)
- **[Node.js](https://nodejs.org/)** (versão 14.x ou superior)

## Como Instalar o Docker

### No Windows ou Mac:
1. Acesse a página oficial do Docker: [https://www.docker.com/get-started](https://www.docker.com/get-started)
2. Baixe e instale o Docker Desktop.
3. Após a instalação, inicie o Docker.

### No Linux:
Siga as instruções específicas para sua distribuição na [documentação oficial](https://docs.docker.com/engine/install/).

### Verificar a Instalação
Após a instalação, você pode verificar se o Docker foi instalado corretamente com o seguinte comando:

```bash
docker --version
```

## Rodando a Aplicação

A aplicação é composta por um backend em .NET e um frontend em React (Next.js). Siga os passos abaixo para rodar os dois componentes localmente.

### 1. Rodando o Backend

O backend está configurado para ser executado com Docker Compose. Siga os passos abaixo para subir o backend:

#### No Docker Desktop (Windows ou Mac):

1. Abra o Docker Desktop e certifique-se de que o Docker está em execução.

2. Acesse a pasta do projeto onde o arquivo `docker-compose.yml` está localizado.
   ```bash
   cd teste-doqr
   ```
3. Suba o backend com o comando:
   ```bash
   docker-compose up
   ```
  Isso irá construir e iniciar o backend no Docker automaticamente.
  
4. Para parar o backend, execute:
   ```bash
   docker-compose down
   ```

#### No Linux:

1. Abra o terminal e acesse a pasta do projeto onde o arquivo docker-compose.yml está localizado.

2. Acesse a pasta do projeto onde o arquivo `docker-compose.yml` está localizado.
   ```bash
   cd teste-doqr
   ```
3. Suba o backend com o comando:
   ```bash
   sudo docker-compose up
   ```
   
  Isso irá construir e iniciar o backend no Docker automaticamente.
  
4. Para parar o backend, execute:
   ```bash
   docker-compose down
   ```

### 1. Rodando o Frontend

  O frontend (Next.js) não é executado diretamente pelo Docker, então você precisará instalar as dependências e rodá-lo manualmente.

  1. Acesse a pasta next-app:
   ```bash
   cd next-app
   ```
    
  2. Instale as dependências com o comando npm:
   ```bash
   npm install
   ```

  3. Gere o build do frontend (se necessário, para produção):
   ```bash
   npm run build
   ```

  4. Inicie o servidor:
   ```bash
   npm start
   ```

  
