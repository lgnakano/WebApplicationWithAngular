Demo is on https://lgnakano.github.io/WebApplicationWithAngular

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
