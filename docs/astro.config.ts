// @ts-check
import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';
import starlightThemeBlack from '@hecatron/starlight-theme-black-category'
import starlightSidebarTopics from 'starlight-sidebar-topics';
import starlightAutoDrafts from 'starlight-auto-drafts';
import { generateSidebarGroups } from './src/sidebar_grps.mjs';

// https://astro.build/config
export default defineConfig({
  site: 'https://htronic-templates.github.io/dotnet-dbtemplate/',
  base: '/dotnet-dbtemplate',
  integrations: [
    starlight({
      title: 'dotnet-dbtemplate',
       logo: {
        dark: './src/assets/logo-dark.svg',
        light: './src/assets/logo-light.svg',
        alt: 'Template Docs Page',
      },
      social: [{ icon: 'github', label: 'GitHub', href: 'https://github.com/htronic-templates/dotnet-dbtemplate' }],
      customCss: [
        './src/styles/themes/theme-deep-purple.css',
      ],
      editLink: {
        baseUrl: 'https://github.com/htronic-templates/dotnet-dbtemplate/edit/master/docs/',
      },
      plugins: [
        starlightThemeBlack({
          navLinks: [
            {
              label: 'Overview',
              link: '/overview',
            },
            {
              label: 'API',
              link: '/api',
            },
          ],
        }),
        starlightSidebarTopics(
	[],
          {
            exclude: ['/api', '/api/**/*', '/overview'],
          }
        ),
        starlightAutoDrafts(),
      ],
    }),
  ],
});
