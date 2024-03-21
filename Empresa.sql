Create Database Empresa
CREATE TABLE Persona (
    IDPersona INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Estado VARCHAR(50)
);


CREATE TABLE TablaEmpleado (
    IDEmpleado INT PRIMARY KEY,
    IDPersona INT,
    Puesto VARCHAR(50),
    Salario DECIMAL(10, 2),
    FechaContratacion DATE,
    FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona)
);

INSERT INTO Persona (IDPersona, Nombre, Apellido, Estado)
VALUES
    (1, 'Gerardo', 'Velasquez', 'Activo'),
    (2, 'Jorge', 'Aguilera', 'Inactivo'),
    (3, 'Rocio', 'Cruz', 'Activo');


INSERT INTO TablaEmpleado (IDEmpleado, IDPersona, Puesto, Salario, FechaContratacion)
VALUES
    (101, 1, 'Gerente', 5000.00, '2020-05-15'),
    (102, 2, 'Contador', 4000.00, '2021-02-20'),
    (103, 3, 'Secretario', 3500.00, '2022-01-10');
