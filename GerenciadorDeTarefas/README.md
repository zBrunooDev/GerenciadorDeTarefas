# 📌 Gerenciador de Tarefas — C# (Console)

Este é um projeto simples desenvolvido em C# para praticar lógica de programação, listas, classes, organização do código e princípios básicos de CRUD no console.

O objetivo é iniciar uma rotina de subir pelo menos **1 projeto por semana** no GitHub e acompanhar minha evolução como desenvolvedor.

---

## 🚀 Funcionalidades

- **Adicionar tarefa**
- **Listar tarefas**
- **Concluir tarefa**
- **Remover tarefa**
- **Menu interativo no console**
- **Código separado em camadas**
  - `TaskItem` → modelo da tarefa  
  - `TaskService` → regras de negócio  
  - `Program` → interface (menu)

---

## 🧠 Tecnologias Utilizadas

- **C#**
- **.NET 8 (ou versão que você estiver usando)**
- Programação Orientada a Objetos (POO)
- Entrada/Saída via Console

---

## 📁 Estrutura do Projeto

GerenciadorTarefas/
│
├── Program.cs # Menu e fluxo principal
├── TaskItem.cs # Modelo da tarefa
└── TaskService.cs # Métodos (CRUD)

yaml
Copiar código

---

## ▶️ Como Executar

1. Clone o repositório:
git clone https://github.com/zBrunooDev/GerenciadorDeTarefas.git

arduino
Copiar código

2. Acesse a pasta do projeto:
cd GerenciadorTarefas

markdown
Copiar código

3. Execute:
dotnet run

yaml
Copiar código

---

## 📚 Aprendizados

- Criação de classes e organização do código  
- Trabalhar com listas (`List<T>`)  
- Menu interativo usando `switch`  
- Construção de um CRUD básico  
- Divisão de responsabilidades (Program → Service → Model)  

---

## 🔮 Próximos Passos (Roadmap)

Este projeto será evoluído aos poucos:

### ✔ **Versão Atual (v1.0)**  
Gerenciador totalmente funcional no console.

### 🚧 **Versão 1.1 – Salvar tarefas em arquivo .txt**
- Leituras e gravações usando `File` e `StreamWriter`
- Persistência simples dos dados

### 🔜 **Versão 2.0 – Interface Windows Forms**
- Tela com lista de tarefas
- Botão para adicionar / remover / concluir

### 🔜 **Versão 3.0 – API Web (ASP.NET Core)**
- CRUD completo em endpoints REST
- Persistência com banco (SQLite ou SQL Server)
- Futuro consumo por um frontend

---

## 📝 Licença

Este projeto é livre para estudo e uso pessoal.

---

## 💬 Contato -> zbrunolima513@hotmail.com

Caso queira trocar ideia sobre C#, lógica ou evolução de projetos, fique à vontade para me chamar!
