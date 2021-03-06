@charset "UTF-8";
body {
  background-color: #2B2840;
  color: #EFF2D8;
}

.encabezado {
  background-image: url(../img/fondo2.jpg);
  height: 440px;
}

.nosotros {
  text-align: center;
  color: #C6D984;
}
.nosotros h1 {
  font-size: 100px;
  font-family: "Anton", sans-serif;
}
.nosotros h2 {
  font-size: 40px;
  margin-top: 20px;
  font-family: "Staatliches", cursive;
}
.nosotros p {
  font-size: 23px;
  margin-top: 10px;
  font-family: "Roboto", sans-serif;
}

.menu {
  display: flex;
  flex-flow: row wrap;
  justify-content: flex-end;
  align-items: flex-start;
  font-size: 20px;
}
.menu div a {
  color: #F2F2F2;
  margin: 10px;
  padding: 10px;
  text-align: center;
}

.contenido {
  display: flex;
}
.contenido .sidebar {
  background-color: #f1f1f1;
  padding: 20px;
  color: #0f0f83;
  font-family: "Staatliches", cursive;
  font-size: 40px;
  align-content: center;
  vertical-align: middle;
}
.contenido .TituloLateral {
  text-align: center;
}
.contenido span {
  color: #9DBF21;
  font-family: "Staatliches", cursive;
  font-size: 40px;
}
.contenido .BotonContacto {
  background-color: #CAC7D9;
  color: #252359;
  font-family: "Anton", sans-serif;
  margin-left: 90px;
  padding-top: 10px;
  padding: 10px;
}

footer {
  background-color: #9DBF21;
}
footer p {
  text-align: center;
  color: #252359;
  font-size: 20px;
  font-family: "Staatliches", cursive;
}

#products {
  display: grid;
  grid-template-areas: "header header header" "nav ferreteria ferreteria" "nav herramientas herramientas" "nav iluminacion iluminacion" "nav construccion construccion" "nav otros otros" "footer footer footer";
  grid-template-rows: 100px repeat(5, 250px) 25px;
  grid-template-columns: 20% auto 15%;
  grid-row-gap: 0;
  grid-column-gap: 0;
  height: 100vh;
  margin: 0;
}
#products header {
  grid-area: header;
  background-color: #0D0C1F;
  color: #9DBF21;
  font-size: 20px;
  font-family: "Staatliches", cursive;
}
#products section {
  display: flex;
  justify-content: center;
  flex-direction: row;
  align-items: center;
}

#footerproductos {
  grid-area: footer;
  background-color: #0D0C1F;
  text-align: center;
  color: #9DBF21;
  font-size: 20px;
  font-family: "Staatliches", cursive;
}

section#ferreteria {
  grid-area: ferreteria;
  background-color: #78748C;
}

#ferreteria div {
  margin-right: 10px;
  margin-left: 10px;
  text-align: center;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  background-color: #ECF2BD;
  color: #0D0C1F;
  padding: 3%;
}

section#herramientas {
  grid-area: herramientas;
}

#herramientas div {
  margin-right: 10px;
  margin-left: 10px;
  text-align: center;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  background-color: #9DBF21;
  color: #0D0C1F;
  padding: 3%;
}

section#iluminacion {
  grid-area: iluminacion;
  background-color: #78748C;
}

#iluminacion div {
  margin-right: 10px;
  margin-left: 10px;
  text-align: center;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  background-color: #ECF2BD;
  color: #0D0C1F;
  padding: 3%;
}

section#construccion {
  grid-area: construccion;
}

#construccion div {
  margin-right: 10px;
  margin-left: 10px;
  text-align: center;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  background-color: #9DBF21;
  color: #0D0C1F;
  padding: 3%;
}

section#otros {
  grid-area: otros;
  background-color: #78748C;
}

#otros a div {
  margin-right: 10px;
  margin-left: 10px;
  text-align: center;
  width: 100px;
  height: 100px;
  border-radius: 50%;
  background-color: #ECF2BD;
  color: #0D0C1F;
  padding: 3%;
}

#products nav {
  grid-area: nav;
  background-color: #0D0C1F;
  color: #9DBF21;
  font-size: 20px;
  font-family: "Staatliches", cursive;
  display: flex;
  justify-content: start;
  flex-direction: column;
  align-items: center;
}

/* Pages: Contactenos - Utilizando Grids*/
#contacto {
  display: grid;
  grid-template-areas: "header header header" "forms img1 img2" "forms img1 img3";
  grid-template-rows: 50px auto auto;
  grid-template-columns: 60% 20% 20%;
  margin: 0;
}

#contacto header {
  grid-area: header;
  background-color: #0D0C1F;
  color: #9DBF21;
}

section#formulario {
  grid-area: forms;
  align-self: center;
  align-content: center;
  margin-left: 280px;
}

section#img-one {
  grid-area: img1;
  margin-top: 20px;
  margin-bottom: 20px;
}

section#img-two {
  grid-area: img2;
  margin-top: 20px;
  margin-bottom: 20px;
}

section#img-three {
  grid-area: img3;
  margin-top: 20px;
  margin-bottom: 20px;
}

/* Media Queries */
@media (min-width: 576px) {
  body {
    overflow: auto;
  }
}
@media (min-width: 768px) {
  body {
    overflow: auto;
  }
}
@media (min-width: 992px) {
  body {
    overflow: auto;
  }
}
@media (min-width: 1200px) {
  body {
    overflow: auto;
  }
}
/* Gradientes / Animaciones */
#EncabezadoPage {
  background-image: linear-gradient(to left, #706E8B, #2A2754);
  height: 100px;
}

#EncabezadoPage2 {
  background-image: linear-gradient(to right, #706E8B, #2A2754);
  height: 100px;
}

#EncabezadoPage h1 {
  animation-duration: 2s;
  animation-name: aparecer;
  animation-iteration-count: infinite;
}

#EncabezadoPage2 h1 {
  animation-duration: 2s;
  animation-name: aparecer;
  animation-iteration-count: infinite;
}

@keyframes aparecer {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
/* Estilos Enlaces / Transiciones */
a:link {
  color: #2B2840;
}

a:visited {
  color: #9DBF21;
}

a:focus {
  border-bottom: 1px solid;
  background: #BAE498;
}

a:hover {
  background: #F2F2F2;
}

a:active {
  color: #2B2840;
}

input type:text {
  transition: all 2s;
  width: 80px;
  height: 20px;
}

input:focus {
  width: 200px;
  font-size: 24px;
}

h1.product-title {
  visibility: visible;
  animation: blinker 5s linear infinite;
}

h2.product-description {
  visibility: hidden;
  float: left;
  animation: hideshow 6s linear infinite;
}

@keyframes blinker {
  50% {
    opacity: 0;
  }
}
@keyframes hideshow {
  0%, 50% {
    width: 0;
  }
  16%, 33% {
    width: auto;
  }
}
/* Estilos p??ginas (Aplicando Bootstrap) */
.carousel-inner img {
  width: 100%;
}

.btn {
  background-color: #323159;
  border: #323159;
  color: #fbfbfd;
}

.btn:hover {
  background-color: #575669;
  border: #323159;
}

.container {
  display: flex;
  justify-content: space-evenly;
}

.card {
  color: #252359;
}

/*# sourceMappingURL=style.cs.map */
