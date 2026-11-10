// @ts-check
import { defineConfig } from 'astro/config';
import starlight from '@astrojs/starlight';
import starlightThemeBlack from '@hecatron/starlight-theme-black-category'
import starlightSidebarTopics from 'starlight-sidebar-topics';
import starlightAutoDrafts from 'starlight-auto-drafts';
import { generateSidebarGroups } from './src/sidebar_grps.mjs';

// https://astro.build/config
export default defineConfig({
  site: 'https://htronic-templates.github.io/dotnet-htronic-dbtemplate/',
  base: '/dotnet-htronic-dbtemplate',
  integrations: [
    starlight({
      title: 'dotnet-htronic-dbtemplate',
       logo: {
        dark: './src/assets/logo-dark.svg',
        light: './src/assets/logo-light.svg',
        alt: 'Template Docs Page',
      },
      social: [{ icon: 'github', label: 'GitHub', href: 'https://github.com/htronic-template/dotnet-htronic-dbtemplate' }],
      customCss: [
        './src/styles/themes/theme-deep-purple.css',
      ],
      editLink: {
        baseUrl: 'https://github.com/htronic-templates/dotnet-htronic-dbtemplate/edit/master/docs/',
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
