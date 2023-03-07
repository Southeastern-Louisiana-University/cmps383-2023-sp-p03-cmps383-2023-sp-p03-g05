import { Outlet, Link } from "react-router-dom";

const Layout = () => {
  return (
    <>
    
      <nav>
        <span>
            <div>
                <button>
                    <Link to="/">Home</Link>
                </button>
                <button>
                    <Link to="/contact">Contact</Link>
                </button> 
            </div>
        </span>
      </nav>



      <Outlet />
    </>
  )
};

export default Layout;
