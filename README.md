Demo is on https://lgnakano.github.io/WebApplicationWithAngular

<h3>To install angular:</h3>
<ul>
  <li>install nodejs from the web</li>
  <li>verify the installation by typing <b>npm -v</b> on a commandb prompt</li>
  <li>install angulal by running <b>npm install -g @angular/cli</b>
  <li>test ng installation by typing <b>ng --version</b> on a command prompt.</li>
  </ul>

<h3>To deploy to github pages, do:</h3>

<ul>
  
<li>cd ClientApp</li>
<li>ng build --prod --output-path ../docs --base-href /WebApplicationWithAngular/</li>
<li>cd ../docs</li>
<li>copy index.html 404.html</li>
<li>check in and push the contents of the docs folder to github</li>
</ul>

<h3>To create a new component:</h3>
<ul>
  <li>cd ClientApp</li>
  <li>ng generate component <b>componentName</b> -m app</li>
</ul>
