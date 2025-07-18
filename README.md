# WebCVIsmael-docker

🌐 **WebCVIsmael-docker** es un portafolio profesional desarrollado con **ASP.NET Core MVC** y desplegado como contenedor **Docker** en la plataforma **Render**. Este sitio web funciona como una carta de presentación interactiva, mostrando experiencia, habilidades técnicas, proyectos y enlaces de contacto.

---

## 🚀 Tecnologías Utilizadas

- ⚙️ **ASP.NET Core MVC 9.0-preview**
- 🐳 **Docker**
- ☁️ **Render.com** (Web Service)
- 🖌️ **Plantilla base**: [Start Bootstrap Resume](https://startbootstrap.com/previews/resume)
- 🔄 **CI/CD manual con GitHub + Render**
- 🧱 **HTML5, CSS3, JavaScript, Bootstrap**

---

## 📁 Estructura del Repositorio

```
WebCVIsmael-docker/
├── WebCVIsmael/              # Proyecto ASP.NET Core MVC
│   ├── Controllers/
│   ├── Views/
│   ├── Models/
│   ├── wwwroot/              # Recursos estáticos
│   ├── Program.cs
│   ├── WebCVIsmael.csproj
│   ├── Dockerfile            # Imagen docker del proyecto
│   └── ...otros archivos
├── .gitignore
├── README.md
└── WebCVIsmael.sln
```

---

## 🐳 Instrucciones para construir y correr el contenedor Docker

### 🔧 Requisitos
- Docker instalado: [https://docs.docker.com/get-docker/](https://docs.docker.com/get-docker/)

### 📦 Construir imagen
```bash
docker build -t webcvismael .
```

### ▶️ Ejecutar contenedor
```bash
docker run -d -p 5000:80 webcvismael
```

Luego abrí tu navegador en:  
🔗 [http://localhost:5000](http://localhost:5000)

---

## 🌍 Sitio desplegado en línea

Podés acceder a la versión en producción aquí:  
🔗 **[https://ismael-salazar-blanco-portfolio.onrender.com](https://ismael-salazar-blanco-portfolio.onrender.com)**

---

## 📄 Funcionalidades actuales

- ✅ Interfaz tipo landing page profesional
- ✅ Navegación entre secciones (Inicio, Experiencia, Habilidades, Contacto)
- ✅ Adaptación responsive para dispositivos móviles
- ✅ Preparado para incluir botón de descarga de CV en PDF
- ✅ Dockerizado y listo para despliegue en servicios cloud

---

## 📌 Objetivo

Este proyecto forma parte del portafolio profesional de **Ismael Salazar Blanco**, desarrollador en sistemas de información con experiencia en tecnologías web, back-end y contenedores. Sirve como ejemplo práctico de integración entre desarrollo ASP.NET Core y despliegue en la nube con Docker.

---

## 📫 Contacto

- LinkedIn: [linkedin.com/in/ismael-salazar-blanco](https://www.linkedin.com/in/ismael-salazar-blanco)
- Repositorio principal: [https://github.com/ismaoft/WebCVIsmael](https://github.com/ismaoft/WebCVIsmael)

---

## 📝 Licencia

Este proyecto se distribuye bajo la Licencia MIT.  
Consulta el archivo `LICENSE` si deseas reutilizar el código.
