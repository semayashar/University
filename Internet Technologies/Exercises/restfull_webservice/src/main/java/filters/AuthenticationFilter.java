package filters;

import java.io.IOException;

import jakarta.servlet.Filter;
import jakarta.servlet.FilterChain;
import jakarta.servlet.FilterConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

public class AuthenticationFilter implements Filter {
  
    public AuthenticationFilter() {
        
    }

	public void destroy() {
		
	}

	public void doFilter(	ServletRequest request,
			ServletResponse response, FilterChain chain) 
			throws IOException, ServletException 
{
	
	HttpServletRequest req = ((HttpServletRequest)request);
	HttpServletResponse res = ((HttpServletResponse)response);

	String user = req.getHeader("user");
	String pass = req.getHeader("pass");

	if(user!=null && pass!=null)
	if(user.equals("admin") && pass.equals("123"))
	{
		chain.doFilter(request, response);
		return;
	}
	
	res.sendError(HttpServletResponse.SC_UNAUTHORIZED);
}


	public void init(FilterConfig fConfig) throws ServletException {
		
	}

}
