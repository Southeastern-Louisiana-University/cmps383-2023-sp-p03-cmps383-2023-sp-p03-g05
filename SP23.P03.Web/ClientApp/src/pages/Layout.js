import { Outlet, Link } from "react-router-dom";


const Layout = () => {
  return (
    <>

<nav class="navbar navbar-expand-lg bg-body-tertiary">
    <div class="container-fluid">
        <a class="navbar-brand" href="#">EnTrack</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav">
            <li class="nav-item">
                <Link class="nav-link" aria-current="page" to="/">Home</Link>
            </li>
            <li class="nav-item">
                <Link class="nav-link" to="/contact">Contact</Link>
            </li>
            <li class="nav-item">
                <Link class="nav-link disabled">Disabled</Link>
            </li>
            <li>
            <img src="/assets/img/bootstrap.svg" alt="ImageNotFound" width="32" height="32"></img>
            </li>
            </ul>
        </div>
    </div>
</nav>


      <Outlet />
    </>
  )
};

export default Layout;
